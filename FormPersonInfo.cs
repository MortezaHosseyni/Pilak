using Pilak.Database.Entities;

namespace Pilak
{
    public partial class FormPersonInfo : Form
    {
        public string? LicensePlate;
        public Person? PersonInfo;

        public FormPersonInfo()
        {
            InitializeComponent();
        }

        private void FormPersonInfo_Load(object sender, EventArgs e)
        {
            if (PersonInfo == null)
            {
                Close();
                return;
            }

            txt_LicensePlate.Text = @$"   {LicensePlate}";

            txt_NationalCode.Text = PersonInfo.NationalCode;

            txt_FirstName.Text = PersonInfo.FirstName;
            txt_LastName.Text = PersonInfo.LastName;
            txt_FatherName.Text = PersonInfo.FatherName;
            txt_PhoneNumber.Text = PersonInfo.PhoneNumber;

            txt_Address.Text = PersonInfo.Address;

            rtb_Bio.Text = PersonInfo.Bio;

            txt_Email.Text = PersonInfo.Email;

            var imagePath = $"person_images/{PersonInfo.Picture}";
            if (File.Exists(imagePath))
                img_Picture.Image = Image.FromFile(imagePath);
        }
    }
}
