namespace Pilak
{
    partial class UcPersonInformation
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

        #region Component Designer generated code

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
            ((System.ComponentModel.ISupportInitialize)img_Picture).BeginInit();
            SuspendLayout();
            // 
            // btn_PrintInformation
            // 
            btn_PrintInformation.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_PrintInformation.Location = new Point(3, 600);
            btn_PrintInformation.Margin = new Padding(3, 4, 3, 4);
            btn_PrintInformation.Name = "btn_PrintInformation";
            btn_PrintInformation.Size = new Size(478, 43);
            btn_PrintInformation.TabIndex = 39;
            btn_PrintInformation.Text = "پرینت اطلاعات";
            btn_PrintInformation.UseVisualStyleBackColor = true;
            // 
            // lbl_Email
            // 
            lbl_Email.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_Email.AutoSize = true;
            lbl_Email.Location = new Point(445, 462);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.RightToLeft = RightToLeft.Yes;
            lbl_Email.Size = new Size(36, 18);
            lbl_Email.TabIndex = 54;
            lbl_Email.Text = "ایمیل";
            // 
            // txt_Email
            // 
            txt_Email.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txt_Email.Enabled = false;
            txt_Email.Location = new Point(0, 459);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(439, 25);
            txt_Email.TabIndex = 53;
            // 
            // lbl_Bio
            // 
            lbl_Bio.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_Bio.AutoSize = true;
            lbl_Bio.Location = new Point(417, 330);
            lbl_Bio.Name = "lbl_Bio";
            lbl_Bio.RightToLeft = RightToLeft.Yes;
            lbl_Bio.Size = new Size(64, 18);
            lbl_Bio.TabIndex = 52;
            lbl_Bio.Text = "در مورد کاربر";
            // 
            // rtb_Bio
            // 
            rtb_Bio.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            rtb_Bio.Location = new Point(0, 351);
            rtb_Bio.Name = "rtb_Bio";
            rtb_Bio.Size = new Size(481, 96);
            rtb_Bio.TabIndex = 51;
            rtb_Bio.Text = "";
            // 
            // lbl_Address
            // 
            lbl_Address.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_Address.AutoSize = true;
            lbl_Address.Location = new Point(447, 247);
            lbl_Address.Name = "lbl_Address";
            lbl_Address.RightToLeft = RightToLeft.Yes;
            lbl_Address.Size = new Size(34, 18);
            lbl_Address.TabIndex = 50;
            lbl_Address.Text = "آدرس";
            // 
            // txt_Address
            // 
            txt_Address.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txt_Address.Enabled = false;
            txt_Address.Location = new Point(0, 268);
            txt_Address.Multiline = true;
            txt_Address.Name = "txt_Address";
            txt_Address.RightToLeft = RightToLeft.Yes;
            txt_Address.Size = new Size(481, 59);
            txt_Address.TabIndex = 49;
            // 
            // lbl_PhoneNumber
            // 
            lbl_PhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_PhoneNumber.AutoSize = true;
            lbl_PhoneNumber.Location = new Point(419, 147);
            lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            lbl_PhoneNumber.RightToLeft = RightToLeft.Yes;
            lbl_PhoneNumber.Size = new Size(65, 18);
            lbl_PhoneNumber.TabIndex = 48;
            lbl_PhoneNumber.Text = "شماره همراه";
            // 
            // txt_PhoneNumber
            // 
            txt_PhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_PhoneNumber.Enabled = false;
            txt_PhoneNumber.Location = new Point(158, 144);
            txt_PhoneNumber.Name = "txt_PhoneNumber";
            txt_PhoneNumber.RightToLeft = RightToLeft.Yes;
            txt_PhoneNumber.Size = new Size(255, 25);
            txt_PhoneNumber.TabIndex = 47;
            // 
            // lbl_FatherName
            // 
            lbl_FatherName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_FatherName.AutoSize = true;
            lbl_FatherName.Location = new Point(419, 116);
            lbl_FatherName.Name = "lbl_FatherName";
            lbl_FatherName.RightToLeft = RightToLeft.Yes;
            lbl_FatherName.Size = new Size(41, 18);
            lbl_FatherName.TabIndex = 46;
            lbl_FatherName.Text = "نام پدر";
            // 
            // txt_FatherName
            // 
            txt_FatherName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_FatherName.Enabled = false;
            txt_FatherName.Location = new Point(158, 113);
            txt_FatherName.Name = "txt_FatherName";
            txt_FatherName.RightToLeft = RightToLeft.Yes;
            txt_FatherName.Size = new Size(255, 25);
            txt_FatherName.TabIndex = 45;
            // 
            // lbl_NationalCode
            // 
            lbl_NationalCode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_NationalCode.AutoSize = true;
            lbl_NationalCode.Location = new Point(419, 6);
            lbl_NationalCode.Name = "lbl_NationalCode";
            lbl_NationalCode.RightToLeft = RightToLeft.Yes;
            lbl_NationalCode.Size = new Size(38, 18);
            lbl_NationalCode.TabIndex = 44;
            lbl_NationalCode.Text = "کدملی";
            // 
            // txt_NationalCode
            // 
            txt_NationalCode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_NationalCode.Enabled = false;
            txt_NationalCode.Location = new Point(158, 3);
            txt_NationalCode.Name = "txt_NationalCode";
            txt_NationalCode.RightToLeft = RightToLeft.Yes;
            txt_NationalCode.Size = new Size(255, 25);
            txt_NationalCode.TabIndex = 43;
            // 
            // lbl_LastName
            // 
            lbl_LastName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_LastName.AutoSize = true;
            lbl_LastName.Location = new Point(419, 85);
            lbl_LastName.Name = "lbl_LastName";
            lbl_LastName.RightToLeft = RightToLeft.Yes;
            lbl_LastName.Size = new Size(68, 18);
            lbl_LastName.TabIndex = 42;
            lbl_LastName.Text = "نام خانوادگی";
            // 
            // lbl_FirstName
            // 
            lbl_FirstName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_FirstName.AutoSize = true;
            lbl_FirstName.Location = new Point(419, 54);
            lbl_FirstName.Name = "lbl_FirstName";
            lbl_FirstName.RightToLeft = RightToLeft.Yes;
            lbl_FirstName.Size = new Size(22, 18);
            lbl_FirstName.TabIndex = 41;
            lbl_FirstName.Text = "نام";
            // 
            // txt_LastName
            // 
            txt_LastName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_LastName.Enabled = false;
            txt_LastName.Location = new Point(158, 82);
            txt_LastName.Name = "txt_LastName";
            txt_LastName.RightToLeft = RightToLeft.Yes;
            txt_LastName.Size = new Size(255, 25);
            txt_LastName.TabIndex = 40;
            // 
            // txt_FirstName
            // 
            txt_FirstName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_FirstName.Enabled = false;
            txt_FirstName.Location = new Point(158, 51);
            txt_FirstName.Name = "txt_FirstName";
            txt_FirstName.RightToLeft = RightToLeft.Yes;
            txt_FirstName.Size = new Size(255, 25);
            txt_FirstName.TabIndex = 38;
            // 
            // img_Picture
            // 
            img_Picture.Image = Properties.Resources.Default_Person;
            img_Picture.Location = new Point(3, 3);
            img_Picture.Name = "img_Picture";
            img_Picture.Size = new Size(149, 166);
            img_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            img_Picture.TabIndex = 37;
            img_Picture.TabStop = false;
            // 
            // ucPersonInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Font = new Font("IRANSansX", 9F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UcPersonInformation";
            Size = new Size(484, 647);
            ((System.ComponentModel.ISupportInitialize)img_Picture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_PrintInformation;
        private Label lbl_Email;
        private TextBox txt_Email;
        private Label lbl_Bio;
        private RichTextBox rtb_Bio;
        private Label lbl_Address;
        private TextBox txt_Address;
        private Label lbl_PhoneNumber;
        private TextBox txt_PhoneNumber;
        private Label lbl_FatherName;
        private TextBox txt_FatherName;
        private Label lbl_NationalCode;
        private TextBox txt_NationalCode;
        private Label lbl_LastName;
        private Label lbl_FirstName;
        private TextBox txt_LastName;
        private TextBox txt_FirstName;
        private PictureBox img_Picture;
    }
}
