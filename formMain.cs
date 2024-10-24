using AForge.Video;
using AForge.Video.DirectShow;
using System.Globalization;

namespace Pilak
{
    public partial class FormMain : Form
    {
        private readonly PersianCalendar _pc = new PersianCalendar();
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        private bool isCameraOn = false;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            DetectCameras();
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
        private void btn_SelectPlateImage_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";
            openFileDialog.Title = "عکس پلاک را انتخاب کنید";

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            var selectedImagePath = openFileDialog.FileName;

            img_PlateImage.Image = Image.FromFile(selectedImagePath);
            img_PlateImage.SizeMode = PictureBoxSizeMode.StretchImage;

            var now =
                $"{_pc.GetYear(DateTime.Now)}/{_pc.GetMonth(DateTime.Now)}/{_pc.GetDayOfMonth(DateTime.Now)} {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}";
            rtb_PlateDetectionLog.Text += $"[{now}] تصویر پلاک انتخاب شد.\n";
            ;
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
        #endregion

        private void tbp_DetectRealtime_Click(object sender, EventArgs e)
        {

        }
    }
}
