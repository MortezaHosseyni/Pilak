using AForge.Video;
using AForge.Video.DirectShow;
using System.Globalization;
using Pilak.Database;
using Pilak.Database.Entities;
using Pilak.Utilities;
using System.Diagnostics;
using Pilak.Models;
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using System.Net.WebSockets;
using System.Text;

namespace Pilak
{
    public partial class FormMain : Form
    {
        private readonly IServiceProvider _serviceProvider;

        private readonly ILicenseRepository _license;
        private readonly IPersonRepository _person;

        private readonly PersianCalendar _pc = new PersianCalendar();
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        private bool isCameraOn = false;

        private License? EditPlateModel;
        private bool editPlate;
        private Person? EditPersonModel;
        private bool editPerson;

        private Image? selectedPersonImage;

        private const string LivePredict = "ws://127.0.0.1:8000/predict/live";
        private const string Predict = "http://127.0.0.1:8000/predict";

        private ClientWebSocket _webSocket;

        #region Form
        public FormMain(IServiceProvider serviceProvider, ILicenseRepository license, IPersonRepository person, FilterInfoCollection videoDevices, VideoCaptureDevice videoSource, ClientWebSocket webSocket)
        {
            InitializeComponent();

            _serviceProvider = serviceProvider;

            _license = license;
            _person = person;
            this.videoDevices = videoDevices;
            this.videoSource = videoSource;

            _webSocket = webSocket;
        }

        private async void FormMain_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            DetectCameras();

            await LoadPersons();

            await LoadPlates();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource is not { IsRunning: true }) return;
            videoSource.SignalToStop();
            videoSource.WaitForStop();
        }

        private void btn_AboutUs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("پیلاک\nv1.0\n\n:طراحی و برنامه‌نویسی\nمرتضی حسینی\nسجاد احمد زاده", "درباره ما", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Image Detection
        private async void btn_SelectPlateImage_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = @"Image Files (*.png;*.jpg)|*.png;*.jpg";
            openFileDialog.Title = @"عکس پلاک را انتخاب کنید";

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            var selectedImagePath = openFileDialog.FileName;

            img_PlateContent.Visible = false;
            img_PlateImage.Image = Image.FromFile(selectedImagePath);
            img_PlateImage.SizeMode = PictureBoxSizeMode.StretchImage;

            var now =
                $"{_pc.GetYear(DateTime.Now)}/{_pc.GetMonth(DateTime.Now)}/{_pc.GetDayOfMonth(DateTime.Now)} {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}";
            rtb_PlateDetectionLog.Text += $"[{now}] تصویر پلاک انتخاب شد.\n";

            btn_SelectPlateImage.Enabled = false;

            //var command = "fastapi dev";
            //RunPredictor(command);

            await Task.Delay(300);

            var result = await Detect(selectedImagePath);

            var image = Image.FromFile($"predictor\\{result.plateImage}");
            img_PlateImage.Image = image;
            img_PersonImage.Paint += (s, e) =>
            {
                e.Graphics.Clear(img_PersonImage.BackColor);

                // Calculate scaling to fit within PictureBox without distortion
                float scaleX = (float)img_PersonImage.Width / image.Width;
                float scaleY = (float)img_PersonImage.Height / image.Height;
                float scale = Math.Min(scaleX, scaleY); // Maintain aspect ratio

                // Calculate the new dimensions of the image
                int newWidth = (int)(image.Width * scale);
                int newHeight = (int)(image.Height * scale);

                // Center the image inside the PictureBox
                int posX = (img_PersonImage.Width - newWidth) / 2;
                int posY = (img_PersonImage.Height - newHeight) / 2;

                // Draw the image with scaling
                e.Graphics.DrawImage(image, posX, posY, newWidth, newHeight);
            };
            img_PersonImage.SizeMode = PictureBoxSizeMode.Normal;
            img_PersonImage.Invalidate();

            img_PlateContent.Visible = true;
            img_PlateContent.Image = Image.FromFile($"predictor\\{result.plateContentImage}");

            result.letterSection = result.letterSection.ToUpper();

            var searchLicense = await _license.Get(result);
            if (searchLicense == null)
            {
                var createPlate = MessageBox.Show("پلاکی با این مشخصات در سیستم ثبت نشده است!\nمی‌خواهید این پلاک را ثبت کنید؟", @"ثبت پلاک", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (createPlate != DialogResult.Yes) return;

                txt_PlateFirstDigit.Text = result.firstDigitSection;
                cmb_PlateLetter.SelectedItem = LetterMapper.GetLetter(result.letterSection.ToUpper());
                txt_PlateSecondDigit.Text = result.secondDigitSection;
                txt_CityCode.Text = result.cityCode;
                tab_MainTab.SelectedTab = tab_MainTab.TabPages["tbp_RegisteredPlates"];

                return;
            }

            using var scope = _serviceProvider.CreateScope();

            var form = scope.ServiceProvider.GetRequiredService<FormPersonInfo>();
            form.LicensePlate =
                $"{searchLicense.CityCode} | {searchLicense.SecondDigitSection} | {LetterMapper.GetLetter(searchLicense.LetterSection ?? string.Empty)} | {searchLicense.FirstDigitSection}";
            form.PersonInfo = searchLicense.Person;
            form.ShowDialog();
        }
        #endregion

        #region RealTime Detection
        private void DetectCameras()
        {
            cmb_Cameras.Items.Clear();

            if (videoDevices.Count <= 0) return;
            for (var i = 0; i < videoDevices.Count; i++)
            {
                cmb_Cameras.Items.Add(videoDevices[i].Name);
            }
            cmb_Cameras.SelectedIndex = 0;

            var now =
                $"{_pc.GetYear(DateTime.Now)}/{_pc.GetMonth(DateTime.Now)}/{_pc.GetDayOfMonth(DateTime.Now)} {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}";
            rtb_RealTimeDetectionLog.Text += $"[{now}] دوربین‌های متصل به سیستم شناسایی شد.\n";
        }

        private void btn_RefreshCameras_Click(object sender, EventArgs e)
        {
            DetectCameras();
        }

        private async void btn_StartCamera_Click(object sender, EventArgs e)
        {
            var now =
                $"{_pc.GetYear(DateTime.Now)}/{_pc.GetMonth(DateTime.Now)}/{_pc.GetDayOfMonth(DateTime.Now)} {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}";

            if (!isCameraOn)
            {
                if (videoDevices.Count > 0)
                {
                    videoSource = new VideoCaptureDevice(videoDevices[cmb_Cameras.SelectedIndex].MonikerString);
                    videoSource.NewFrame += (sender, eventArgs) =>
                    {
                        _ = Video_NewFrame(sender, eventArgs);
                    };
                    videoSource.Start();
                }
                else
                {
                    MessageBox.Show("اتصال با دوربین برقرار نشد.", "خطا در شناسایی دوربین", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                btn_StartCamera.Text = "غیرفعالسازی دوربین";
                cmb_Cameras.Enabled = false;
                isCameraOn = true;

                await ConnectWebSocketAsync();

                AppendText($"[{now}] دوربین {videoDevices[cmb_Cameras.SelectedIndex].Name} فعال شد.\n");
            }
            else
            {
                if (videoSource is { IsRunning: true })
                {
                    videoSource.SignalToStop();
                    videoSource.WaitForStop();
                }
                btn_StartCamera.Text = "فعالسازی دوربین";
                cmb_Cameras.Enabled = true;
                isCameraOn = false;

                await DisconnectWebSocketAsync();

                AppendText($"[{now}] دوربین {videoDevices[cmb_Cameras.SelectedIndex].Name} غیرفعال شد.\n");
            }
        }

        private async Task Video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            var bitmap = (Bitmap)eventArgs.Frame.Clone();
            img_Camera.Image = bitmap;

            using var memoryStream = new MemoryStream();
            
            bitmap.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] frameBytes = memoryStream.ToArray();

            await SendFrameToWebSocket(frameBytes);
        }

        private async Task ConnectWebSocketAsync()
        {
            try
            {
                await _webSocket!.ConnectAsync(new Uri(LivePredict), CancellationToken.None);
                AppendText("WebSocket connected.\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to connect to WebSocket: {ex.Message}", "WebSocket Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task SendFrameToWebSocket(byte[] frameBytes)
        {
            if (_webSocket!.State == WebSocketState.Open)
            {
                try
                {
                    await _webSocket.SendAsync(new ArraySegment<byte>(frameBytes), WebSocketMessageType.Binary, true, CancellationToken.None);
                    AppendText($"Frame sent to WebSocket at {DateTime.Now}\n");

                    await ReceiveResponse();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to send frame: {ex.Message}", "WebSocket Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AppendText("WebSocket is not connected.\n");
            }
        }

        private async Task ReceiveResponse()
        {
            try
            {
                var buffer = new byte[1024 * 4];
                var result = await _webSocket!.ReceiveAsync(
                    new ArraySegment<byte>(buffer),
                    CancellationToken.None
                );

                string response = Encoding.UTF8.GetString(buffer, 0, result.Count);

                AppendText(response);

                if (result.MessageType == WebSocketMessageType.Close)
                {
                    await _webSocket.CloseAsync(
                        WebSocketCloseStatus.NormalClosure,
                        string.Empty,
                        CancellationToken.None
                    );
                }
            }
            catch (Exception ex)
            {
                AppendText(ex.Message);
            }
        }

        private async Task DisconnectWebSocketAsync()
        {
            if (_webSocket?.State == WebSocketState.Open)
            {
                await _webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Closing", CancellationToken.None);
                rtb_RealTimeDetectionLog.Text += "WebSocket disconnected.\n";
            }
        }

        private void AppendText(string text)
        {
            if (rtb_RealTimeDetectionLog.InvokeRequired)
                rtb_RealTimeDetectionLog.Invoke(new Action(() => rtb_RealTimeDetectionLog.AppendText(text)));
            else
                rtb_RealTimeDetectionLog.AppendText(text);
        }

        #endregion

        #region Registered Plates
        private async Task LoadPlates()
        {
            var plates = await _license.Get();
            dgv_Plates.Rows.Clear();

            foreach (var plate in plates)
            {
                var letterCode = LetterMapper.GetLetter(plate.LetterSection ?? string.Empty);

                var combinedSection = $"{plate.CityCode} | {plate.SecondDigitSection} | {letterCode} | {plate.FirstDigitSection}";

                dgv_Plates.Rows.Add(plate.Id, combinedSection, plate.PersonName, plate.IssueDate.ToPersianDate(), plate.ExpiryDate.ToPersianDate(), plate.CreatedAt.ToPersianDate(), plate.PersonId);
            }
        }

        private async void btn_AddPlate_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txt_PlateFirstDigit.Text) || txt_PlateFirstDigit.Text.Length != 2) ||
                string.IsNullOrEmpty(cmb_PlateLetter.Text) ||
                (string.IsNullOrEmpty(txt_PlateSecondDigit.Text) || txt_PlateSecondDigit.Text.Length != 3) ||
                (string.IsNullOrEmpty(txt_CityCode.Text) || txt_CityCode.Text.Length != 2) ||
                string.IsNullOrEmpty(cmb_PlatePerson.Text))
            {
                MessageBox.Show(@"لطفا اطلاعات را به درستی وارد کنید.", @"اطلاعات نامعتبر", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var newPlate = new License
            {
                Id = Guid.NewGuid(),
                FirstDigitSection = int.Parse(txt_PlateFirstDigit.Text),
                LetterSection = LetterMapper.GetCode(cmb_PlateLetter.Text),
                SecondDigitSection = int.Parse(txt_PlateSecondDigit.Text),
                CityCode = int.Parse(txt_CityCode.Text),
                PersonId = (Guid)cmb_PlatePerson.SelectedValue!,
                IssueDate = Convert.ToDateTime(dtp_IssueDate.Text),
                ExpiryDate = Convert.ToDateTime(dtp_ExpiryDate.Text),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            if (editPlate)
            {
                if (EditPlateModel != null)
                {
                    newPlate.Id = EditPlateModel.Id;
                    newPlate.CreatedAt = EditPlateModel.CreatedAt;

                    ClearPlateFields();

                    btn_CancelPlateEdit.Visible = false;
                    btn_EditPlate.Visible = true;
                    editPlate = false;

                    await _license.Update(newPlate);
                    await LoadPlates();

                    return;
                }
            }

            await _license.Add(newPlate);
            await LoadPlates();

            ClearPlateFields();
        }

        private async void btn_EditPlate_Click(object sender, EventArgs e)
        {
            var selectedPlate = dgv_Plates.SelectedRows[0];

            if (selectedPlate == null) return;

            var id = selectedPlate.Cells["col_plate_Id"].Value;
            if (id == null) return;

            var plate = await _license.Get(Guid.Parse(selectedPlate.Cells["col_plate_Id"].Value.ToString()!));
            if (plate == null) return;

            btn_CancelPlateEdit.Visible = true;
            btn_EditPlate.Visible = false;
            editPlate = true;
            EditPlateModel = plate;

            cmb_PlatePerson.SelectedItem = plate.PersonId;
            txt_PlateFirstDigit.Text = plate.FirstDigitSection.ToString();
            cmb_PlateLetter.SelectedItem = LetterMapper.GetLetter(plate.LetterSection!);
            txt_PlateSecondDigit.Text = plate.SecondDigitSection.ToString();
            txt_CityCode.Text = plate.CityCode.ToString();
            dtp_IssueDate.Value = plate.IssueDate;
            dtp_ExpiryDate.Value = plate.ExpiryDate;
        }

        private void btn_CancelPlateEdit_Click(object sender, EventArgs e)
        {
            ClearPlateFields();

            btn_CancelPlateEdit.Visible = false;
            btn_EditPlate.Visible = true;
            editPlate = false;
        }

        private void ClearPlateFields()
        {
            cmb_PlatePerson.SelectedItem = string.Empty;
            txt_PlateFirstDigit.Text = string.Empty;
            cmb_PlateLetter.SelectedItem = string.Empty;
            txt_PlateSecondDigit.Text = string.Empty;
            txt_CityCode.Text = string.Empty;
            dtp_IssueDate.Value = DateTime.Now;
            dtp_ExpiryDate.Value = DateTime.Now;
        }

        private void txt_PlateFirstDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_PlateSecondDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_CityCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Registered Persons
        private async Task LoadPersons()
        {
            var persons = await _person.Get();
            dgv_Persons.Rows.Clear();

            foreach (var person in persons)
            {
                dgv_Persons.Rows.Add(person.NationalCode, person.FirstName, person.LastName, person.FatherName, person.PhoneNumber, person.Email, person.Bio, person.Address);
            }

            cmb_PlatePerson.DataSource = null;
            cmb_PlatePerson.DataSource = persons;
            cmb_PlatePerson.DisplayMember = "FullName";
            cmb_PlatePerson.ValueMember = "Id";
        }

        private void img_PersonImage_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.png;*.jpg";
            openFileDialog.Title = "عکس شهروند را انتخاب کنید.";

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            selectedPersonImage = Image.FromFile(openFileDialog.FileName);
            img_PersonImage.Image = selectedPersonImage;
            img_PersonImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private async void btn_AddPerson_Click(object sender, EventArgs e)
        {
            try
            {
                var folderPath = Path.Combine(Application.StartupPath, "person_images");
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                var uniqueFileName = $"{Guid.NewGuid()}.png";
                var filePath = Path.Combine(folderPath, uniqueFileName);
                selectedPersonImage?.Save(filePath);

                var newPerson = new Person(txt_NationalCode.Text, txt_FirstName.Text, txt_LastName.Text,
                    txt_FatherName.Text, rtb_Address.Text, txt_PhoneNumber.Text, txt_About.Text, uniqueFileName)
                {
                    Id = Guid.NewGuid(),
                    Email = txt_Email.Text,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };

                await _person.Add(newPerson);

                await LoadPersons();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطایی رخ داد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_PersonInfo_Click(object sender, EventArgs e)
        {
            using var scope = _serviceProvider.CreateScope();

            var form = scope.ServiceProvider.GetRequiredService<FormPersonInfo>();
            form.ShowDialog();
        }
        #endregion

        #region Detection
        private static void RunPredictor(string command)
        {
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = command,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = false,
                    WorkingDirectory = $"{AppDomain.CurrentDomain.BaseDirectory}/predictor"
                };

                using var process = Process.Start(psi) ?? throw new Exception("Failed to start process.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(@$"Error running Python command: {ex.Message}", @"ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task<PlateDetectionResult> Detect(string imagePath)
        {
            try
            {
                var payload = new
                {
                    image_path = imagePath
                };

                string jsonPayload = JsonSerializer.Serialize(payload);

                var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                var client = new HttpClient();

                HttpResponseMessage response = await client.PostAsync(Predict, content);

                response.EnsureSuccessStatusCode();

                string responseContent = await response.Content.ReadAsStringAsync();
                var plateInfo = JsonSerializer.Deserialize<PlateDetectionResult>(responseContent);

                if (plateInfo == null)
                {
                    MessageBox.Show("هنگام پردازش تصویر خطایی رخ داد", "خطا!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new Exception();
                }

                return plateInfo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception(ex.Message);
            }
        }

        public async Task DetectRealtime(string imagePath)
        {
            using var webSocket = new ClientWebSocket();
            
            try
            {
                await webSocket.ConnectAsync(new Uri(LivePredict), CancellationToken.None);

                var messageBuffer = Encoding.UTF8.GetBytes(imagePath);
                await webSocket.SendAsync(new ArraySegment<byte>(messageBuffer), WebSocketMessageType.Text, true, CancellationToken.None);

                var receiveBuffer = new byte[8192];
                var result = await webSocket.ReceiveAsync(new ArraySegment<byte>(receiveBuffer), CancellationToken.None);
                var imageData = new byte[result.Count];
                Array.Copy(receiveBuffer, imageData, result.Count);

                using (var ms = new MemoryStream(imageData))
                {
                    Image image = Image.FromStream(ms);
                    img_Camera.Invoke(new Action(() => img_Camera.Image = image));
                }

                await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Closing", CancellationToken.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}
