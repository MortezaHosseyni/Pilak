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

        private Image? selectedPersonImage;

        public FormMain(IServiceProvider serviceProvider, ILicenseRepository license, IPersonRepository person, FilterInfoCollection videoDevices, VideoCaptureDevice videoSource)
        {
            InitializeComponent();

            _serviceProvider = serviceProvider;

            _license = license;
            _person = person;
            this.videoDevices = videoDevices;
            this.videoSource = videoSource;
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

            const string pythonScript = "pilak.py";
            const string bestContentModel = "best_content.pt";
            const string bestEnvModel = "best_env.pt";
            const string output = "predictor/output.json";

            var command = $"{pythonScript} {bestContentModel} {bestEnvModel} \"{selectedImagePath.Replace("\\", "/")}\"";
            RunPredictor(command);

            await Task.Delay(300);

            btn_SelectPlateImage.Enabled = true;

            if (!File.Exists(output))
            {
                MessageBox.Show(@"هنگام پردازش تصویر خطایی رخ داد.", @"پردازش تصویر", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var jsonOutput = await File.ReadAllTextAsync(output);
            var result = JsonSerializer.Deserialize<PlateDetectionResult>(jsonOutput);
            if (result == null)
            {
                MessageBox.Show(@"هنگام پردازش تصویر خطایی رخ داد.", @"پردازش تصویر", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            
            img_PlateImage.Image = Image.FromFile($"predictor\\{result.plateImage}\\image0.jpg");

            img_PlateContent.Visible = true;
            img_PlateContent.Image = Image.FromFile($"predictor\\{result.plateContentImage}\\image0.jpg");

            result.letterSection = LetterMapper.GetCode(result.letterSection);

            var searchLicense = await _license.Get(result);
            if (searchLicense == null)
            {
                var createPlate = MessageBox.Show("پلاکی با این مشخصات در سیستم ثبت نشده است!\nمی‌خواهید این پلاک را ثبت کنید؟", @"ثبت پلاک", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (createPlate != DialogResult.Yes) return;

                txt_PlateFirstDigit.Text = result.firstDigitSection;
                cmb_PlateLetter.SelectedItem = result.letterSection;
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

        private void btn_StartCamera_Click(object sender, EventArgs e)
        {
            var now =
                $"{_pc.GetYear(DateTime.Now)}/{_pc.GetMonth(DateTime.Now)}/{_pc.GetDayOfMonth(DateTime.Now)} {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}";

            if (!isCameraOn)
            {
                if (videoDevices.Count > 0)
                {
                    videoSource = new VideoCaptureDevice(videoDevices[cmb_Cameras.SelectedIndex].MonikerString);
                    videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
                    videoSource.Start();
                }
                else
                {
                    MessageBox.Show("اتصال با دوربین برقرار نشد.", "خطا در شناسایی دوربین", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                btn_StartCamera.Text = "غیرفعالسازی دوربین";
                cmb_Cameras.Enabled = false;
                isCameraOn = true;

                rtb_RealTimeDetectionLog.Text += $"[{now}] دوربین {videoDevices[cmb_Cameras.SelectedIndex].Name} فعال شد.\n";
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

                rtb_RealTimeDetectionLog.Text += $"[{now}] دوربین {videoDevices[cmb_Cameras.SelectedIndex].Name} غیرفعال شد.\n";
            }
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            var bitmap = (Bitmap)eventArgs.Frame.Clone();
            img_Camera.Image = bitmap;
        }

        private void tbp_DetectRealtime_Click(object sender, EventArgs e)
        {

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

                dgv_Plates.Rows.Add(combinedSection, plate.PersonName, plate.IssueDate.ToPersianDate(), plate.ExpiryDate.ToPersianDate(), plate.CreatedAt.ToPersianDate());
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
                MessageBox.Show("لطفا اطلاعات را به درستی وارد کنید.", "اطلاعات نامعتبر", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var newPlate = new License()
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

            await _license.Add(newPlate);
            await LoadPlates();
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

        #region Detection
        private static void RunPredictor(string command)
        {
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = "python",
                    Arguments = command,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    WorkingDirectory = $"{AppDomain.CurrentDomain.BaseDirectory}/predictor"
                };

                using var process = Process.Start(psi);
                if (process == null)
                    throw new Exception("Failed to start process.");

                process.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@$"Error running Python command: {ex.Message}", @"ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
