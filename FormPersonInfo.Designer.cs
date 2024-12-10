namespace Pilak
{
    partial class FormPersonInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_PrintInformation = new Button();
            lbl_Email = new Label();
            txt_Email = new TextBox();
            lbl_Bio = new Label();
            rtb_Bio = new RichTextBox();
            lbl_Address = new Label();
            txt_Address = new TextBox();
            lbl_PhoneNumber = new Label();
            txt_PhoneNumber = new TextBox();
            lbl_FatherName = new Label();
            txt_FatherName = new TextBox();
            lbl_NationalCode = new Label();
            txt_NationalCode = new TextBox();
            lbl_LastName = new Label();
            lbl_FirstName = new Label();
            txt_LastName = new TextBox();
            txt_FirstName = new TextBox();
            img_Picture = new PictureBox();
            txt_LicensePlate = new TextBox();
            ((System.ComponentModel.ISupportInitialize)img_Picture).BeginInit();
            SuspendLayout();
            // 
            // btn_PrintInformation
            // 
            btn_PrintInformation.Location = new Point(12, 655);
            btn_PrintInformation.Margin = new Padding(3, 5, 3, 5);
            btn_PrintInformation.Name = "btn_PrintInformation";
            btn_PrintInformation.Size = new Size(527, 52);
            btn_PrintInformation.TabIndex = 57;
            btn_PrintInformation.Text = "پرینت اطلاعات";
            btn_PrintInformation.UseVisualStyleBackColor = true;
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Location = new Point(476, 611);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.RightToLeft = RightToLeft.Yes;
            lbl_Email.Size = new Size(36, 18);
            lbl_Email.TabIndex = 72;
            lbl_Email.Text = "ایمیل";
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(12, 608);
            txt_Email.Margin = new Padding(3, 4, 3, 4);
            txt_Email.Name = "txt_Email";
            txt_Email.ReadOnly = true;
            txt_Email.Size = new Size(453, 25);
            txt_Email.TabIndex = 71;
            // 
            // lbl_Bio
            // 
            lbl_Bio.AutoSize = true;
            lbl_Bio.Location = new Point(471, 457);
            lbl_Bio.Name = "lbl_Bio";
            lbl_Bio.RightToLeft = RightToLeft.Yes;
            lbl_Bio.Size = new Size(64, 18);
            lbl_Bio.TabIndex = 70;
            lbl_Bio.Text = "در مورد کاربر";
            // 
            // rtb_Bio
            // 
            rtb_Bio.Location = new Point(12, 479);
            rtb_Bio.Margin = new Padding(3, 4, 3, 4);
            rtb_Bio.Name = "rtb_Bio";
            rtb_Bio.ReadOnly = true;
            rtb_Bio.RightToLeft = RightToLeft.Yes;
            rtb_Bio.Size = new Size(524, 114);
            rtb_Bio.TabIndex = 69;
            rtb_Bio.Text = "";
            // 
            // lbl_Address
            // 
            lbl_Address.AutoSize = true;
            lbl_Address.Location = new Point(501, 357);
            lbl_Address.Name = "lbl_Address";
            lbl_Address.RightToLeft = RightToLeft.Yes;
            lbl_Address.Size = new Size(34, 18);
            lbl_Address.TabIndex = 68;
            lbl_Address.Text = "آدرس";
            // 
            // txt_Address
            // 
            txt_Address.Location = new Point(12, 379);
            txt_Address.Margin = new Padding(3, 4, 3, 4);
            txt_Address.Multiline = true;
            txt_Address.Name = "txt_Address";
            txt_Address.ReadOnly = true;
            txt_Address.RightToLeft = RightToLeft.Yes;
            txt_Address.Size = new Size(524, 70);
            txt_Address.TabIndex = 67;
            // 
            // lbl_PhoneNumber
            // 
            lbl_PhoneNumber.AutoSize = true;
            lbl_PhoneNumber.Location = new Point(471, 290);
            lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            lbl_PhoneNumber.RightToLeft = RightToLeft.Yes;
            lbl_PhoneNumber.Size = new Size(65, 18);
            lbl_PhoneNumber.TabIndex = 66;
            lbl_PhoneNumber.Text = "شماره همراه";
            // 
            // txt_PhoneNumber
            // 
            txt_PhoneNumber.Location = new Point(210, 287);
            txt_PhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txt_PhoneNumber.Name = "txt_PhoneNumber";
            txt_PhoneNumber.ReadOnly = true;
            txt_PhoneNumber.RightToLeft = RightToLeft.Yes;
            txt_PhoneNumber.Size = new Size(255, 25);
            txt_PhoneNumber.TabIndex = 65;
            // 
            // lbl_FatherName
            // 
            lbl_FatherName.AutoSize = true;
            lbl_FatherName.Location = new Point(471, 253);
            lbl_FatherName.Name = "lbl_FatherName";
            lbl_FatherName.RightToLeft = RightToLeft.Yes;
            lbl_FatherName.Size = new Size(41, 18);
            lbl_FatherName.TabIndex = 64;
            lbl_FatherName.Text = "نام پدر";
            // 
            // txt_FatherName
            // 
            txt_FatherName.Location = new Point(210, 249);
            txt_FatherName.Margin = new Padding(3, 4, 3, 4);
            txt_FatherName.Name = "txt_FatherName";
            txt_FatherName.ReadOnly = true;
            txt_FatherName.RightToLeft = RightToLeft.Yes;
            txt_FatherName.Size = new Size(255, 25);
            txt_FatherName.TabIndex = 63;
            // 
            // lbl_NationalCode
            // 
            lbl_NationalCode.AutoSize = true;
            lbl_NationalCode.Location = new Point(471, 121);
            lbl_NationalCode.Name = "lbl_NationalCode";
            lbl_NationalCode.RightToLeft = RightToLeft.Yes;
            lbl_NationalCode.Size = new Size(38, 18);
            lbl_NationalCode.TabIndex = 62;
            lbl_NationalCode.Text = "کدملی";
            // 
            // txt_NationalCode
            // 
            txt_NationalCode.Location = new Point(210, 117);
            txt_NationalCode.Margin = new Padding(3, 4, 3, 4);
            txt_NationalCode.Name = "txt_NationalCode";
            txt_NationalCode.ReadOnly = true;
            txt_NationalCode.RightToLeft = RightToLeft.Yes;
            txt_NationalCode.Size = new Size(255, 25);
            txt_NationalCode.TabIndex = 61;
            // 
            // lbl_LastName
            // 
            lbl_LastName.AutoSize = true;
            lbl_LastName.Location = new Point(471, 216);
            lbl_LastName.Name = "lbl_LastName";
            lbl_LastName.RightToLeft = RightToLeft.Yes;
            lbl_LastName.Size = new Size(68, 18);
            lbl_LastName.TabIndex = 60;
            lbl_LastName.Text = "نام خانوادگی";
            // 
            // lbl_FirstName
            // 
            lbl_FirstName.AutoSize = true;
            lbl_FirstName.Location = new Point(471, 179);
            lbl_FirstName.Name = "lbl_FirstName";
            lbl_FirstName.RightToLeft = RightToLeft.Yes;
            lbl_FirstName.Size = new Size(22, 18);
            lbl_FirstName.TabIndex = 59;
            lbl_FirstName.Text = "نام";
            // 
            // txt_LastName
            // 
            txt_LastName.Location = new Point(210, 212);
            txt_LastName.Margin = new Padding(3, 4, 3, 4);
            txt_LastName.Name = "txt_LastName";
            txt_LastName.ReadOnly = true;
            txt_LastName.RightToLeft = RightToLeft.Yes;
            txt_LastName.Size = new Size(255, 25);
            txt_LastName.TabIndex = 58;
            // 
            // txt_FirstName
            // 
            txt_FirstName.Location = new Point(210, 175);
            txt_FirstName.Margin = new Padding(3, 4, 3, 4);
            txt_FirstName.Name = "txt_FirstName";
            txt_FirstName.ReadOnly = true;
            txt_FirstName.RightToLeft = RightToLeft.Yes;
            txt_FirstName.Size = new Size(255, 25);
            txt_FirstName.TabIndex = 56;
            // 
            // img_Picture
            // 
            img_Picture.Image = Properties.Resources.Default_Person;
            img_Picture.Location = new Point(12, 117);
            img_Picture.Margin = new Padding(3, 4, 3, 4);
            img_Picture.Name = "img_Picture";
            img_Picture.Size = new Size(192, 199);
            img_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            img_Picture.TabIndex = 55;
            img_Picture.TabStop = false;
            // 
            // txt_LicensePlate
            // 
            txt_LicensePlate.Font = new Font("IRANSansX", 28F);
            txt_LicensePlate.Location = new Point(12, 25);
            txt_LicensePlate.Name = "txt_LicensePlate";
            txt_LicensePlate.ReadOnly = true;
            txt_LicensePlate.RightToLeft = RightToLeft.Yes;
            txt_LicensePlate.Size = new Size(523, 63);
            txt_LicensePlate.TabIndex = 73;
            // 
            // FormPersonInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 721);
            Controls.Add(txt_LicensePlate);
            Controls.Add(btn_PrintInformation);
            Controls.Add(lbl_Email);
            Controls.Add(txt_Email);
            Controls.Add(lbl_Bio);
            Controls.Add(rtb_Bio);
            Controls.Add(lbl_Address);
            Controls.Add(txt_Address);
            Controls.Add(lbl_PhoneNumber);
            Controls.Add(txt_PhoneNumber);
            Controls.Add(lbl_FatherName);
            Controls.Add(txt_FatherName);
            Controls.Add(lbl_NationalCode);
            Controls.Add(txt_NationalCode);
            Controls.Add(lbl_LastName);
            Controls.Add(lbl_FirstName);
            Controls.Add(txt_LastName);
            Controls.Add(txt_FirstName);
            Controls.Add(img_Picture);
            Font = new Font("IRANSansX", 9F, FontStyle.Regular, GraphicsUnit.Point, 178);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimumSize = new Size(565, 668);
            Name = "FormPersonInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اطلاعات شهروند";
            Load += FormPersonInfo_Load;
            ((System.ComponentModel.ISupportInitialize)img_Picture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_PrintInformation;
        private Label lbl_Email;
        private Label lbl_Bio;
        private Label lbl_Address;
        private Label lbl_PhoneNumber;
        private Label lbl_FatherName;
        private Label lbl_NationalCode;
        private Label lbl_LastName;
        private Label lbl_FirstName;
        public TextBox txt_Email;
        public RichTextBox rtb_Bio;
        public TextBox txt_Address;
        public TextBox txt_PhoneNumber;
        public TextBox txt_FatherName;
        public TextBox txt_LastName;
        public TextBox txt_FirstName;
        public TextBox txt_NationalCode;
        public PictureBox img_Picture;
        private TextBox txt_LicensePlate;
    }
}