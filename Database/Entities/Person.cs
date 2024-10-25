using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using Pilak.Utilities;

namespace Pilak.Database.Entities
{
    public class Person : BaseEntity
    {
        [Required(ErrorMessage = "کدملی شهروند را وارد کنید.")][MaxLength(225)] public string NationalCode { get; private set; }
        [Required(ErrorMessage = "نام شهروند را وارد کنید.")][MaxLength(225)] public string FirstName { get; private set; }
        [Required(ErrorMessage = "نام‌خانوادگی شهروند را وارد کنید.")][MaxLength(225)] public string LastName { get; private set; }
        [Required(ErrorMessage = "نام‌ پدر شهروند را وارد کنید.")][MaxLength(225)] public string FatherName { get; private set; }
        [Required(ErrorMessage = "آدرس شهروند را وارد کنید.")][MaxLength(800)] public string Address { get; private set; }
        [Required(ErrorMessage = "شماره همراه شهروند را وارد کنید.")][MaxLength(11)] public string PhoneNumber { get; private set; }
        [MaxLength(500)] public string? Bio { get; private set; }
        [EmailAddress][MaxLength(800)] public string? Email { get; set; }
        [MaxLength(225)] public string? Picture { get; private set; }

        #region Relations
        public virtual ICollection<License>? Licenses { get; set; }
        #endregion

        public string FullName => $"{FirstName} {LastName} ({NationalCode})";

        public Person(string nationalCode, string firstName, string lastName, string fatherName, string address, string phoneNumber, string? bio, string? picture)
        {
            if (!string.IsNullOrEmpty(nationalCode) && !Regex.IsMatch(nationalCode, @"^\d+$") && nationalCode?.Length > 10)
            {
                MessageBox.Show("کد ملی نامعتبر میباشد.", "خطا: کد ملی", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception("The national code must be 10 digits.");
            }
            NationalCode = Sanitize.Clarify(nationalCode);

            FirstName = Sanitize.Clarify(firstName);
            LastName = Sanitize.Clarify(lastName);

            FatherName = Sanitize.Clarify(fatherName);

            Address = Sanitize.Clarify(address);

            if (!ValidNumber(phoneNumber))
            {
                MessageBox.Show("شماره همراه معتبر نیست.", "خطا: شماره همراه کاربر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception("Phone number is not valid!");
            }
            PhoneNumber = phoneNumber;

            Bio = Sanitize.Clarify(bio);

            if (!string.IsNullOrEmpty(picture) && !Regex.IsMatch(picture, @"^.+\.(png|jpg|jpeg|bmp|webp)$"))
            {
                MessageBox.Show("تصویر کاربر معتبر نیست!\nفرمت‌های قابل قبول: png, jpg, jpeg, bmp و webp.", "خطا: تصویر کاربر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception("User image is invalid.");
            }
            Picture = picture;
        }

        private static bool ValidNumber(string phoneNumber)
        {
            string[] prefixes =
            [
                "0910",   "0911",   "0912",   "0913",   "0914",   "0915",   "0916",
                "0917",   "0918",   "0919",   "0990",   "0991",   "0992",   "0993",
                "0994",   "0995",   "0996",   "0932",   "0930",   "0933",   "0935",
                "0936",   "0937",   "0938",   "0939",   "0900",   "0901",   "0902",
                "0903",   "0904",   "0905",   "0941",   "0920",   "0921",   "0922",
                "0923",   "0931",   "0934",   "099910", "099911", "099913", "099999",
                "09990",  "099810", "099811", "099812", "099813", "099814", "099815",
                "099816", "099817", "09998",  "0994"
            ];

            return !string.IsNullOrEmpty(phoneNumber) && Regex.IsMatch(phoneNumber, @"^(" + string.Join("|", prefixes) + ")");
        }
    }
}
