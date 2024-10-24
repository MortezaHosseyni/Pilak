using System.Globalization;

namespace Pilak
{
    public partial class FormMain : Form
    {
        private PersianCalendar pc = new PersianCalendar();

        public FormMain()
        {
            InitializeComponent();
        }

        private void btn_AboutUs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("پیلاک\nv1.0\n\n:طراحی و برنامه‌نویسی\nمرتضی حسینی\nسجاد احمد زاده", "درباره ما", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

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
                $"{pc.GetYear(DateTime.Now)}/{pc.GetMonth(DateTime.Now)}/{pc.GetDayOfMonth(DateTime.Now)} {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}";
            rtb_PlateDetectionLog.Text += $"[{now}] تصویر پلاک انتخاب شد.\n";
;        }
    }
}
