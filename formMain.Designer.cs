namespace Pilak
{
    partial class formMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            tab_MainTab = new TabControl();
            tbp_DetectByPicture = new TabPage();
            pnl_UserInformation = new Panel();
            usc_PersonInformation = new ucPersonInformation();
            pnl_PlateDetection = new Panel();
            rtb_PlateDetectionLog = new RichTextBox();
            btn_SelectPlateImage = new Button();
            img_PlateImage = new PictureBox();
            tbp_DetectRealtime = new TabPage();
            pnl_RealTimeDetection = new Panel();
            btn_ChooseCamera = new Button();
            cmb_Cameras = new ComboBox();
            rtb_RealTimeDetectionLog = new RichTextBox();
            btn_RealTimeDetect = new Button();
            img_Camera = new PictureBox();
            pnl_rtTab_UserInformation = new Panel();
            ucPersonInformation1 = new ucPersonInformation();
            tbp_RegisteredPlates = new TabPage();
            pnl_AddPlate = new Panel();
            lbl_ExpiryDate = new Label();
            lbl_IssueDate = new Label();
            dtp_ExpiryDate = new DateTimePicker();
            dtp_IssueDate = new DateTimePicker();
            cmb_PlatePerson = new ComboBox();
            btn_AddPlate = new Button();
            txt_CityCode = new TextBox();
            txt_PlateSecondDigit = new TextBox();
            cmb_PlateLetter = new ComboBox();
            txt_PlateFirstDigit = new TextBox();
            dgv_Plates = new DataGridView();
            col_plate_Plate = new DataGridViewTextBoxColumn();
            col_plate_IssuedDate = new DataGridViewTextBoxColumn();
            col_plate_ExpiryDate = new DataGridViewTextBoxColumn();
            col_plate_CreatedAt = new DataGridViewTextBoxColumn();
            tbp_RegisteredPersons = new TabPage();
            tab_MainTab.SuspendLayout();
            tbp_DetectByPicture.SuspendLayout();
            pnl_UserInformation.SuspendLayout();
            pnl_PlateDetection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_PlateImage).BeginInit();
            tbp_DetectRealtime.SuspendLayout();
            pnl_RealTimeDetection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_Camera).BeginInit();
            pnl_rtTab_UserInformation.SuspendLayout();
            tbp_RegisteredPlates.SuspendLayout();
            pnl_AddPlate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Plates).BeginInit();
            SuspendLayout();
            // 
            // tab_MainTab
            // 
            tab_MainTab.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tab_MainTab.Controls.Add(tbp_DetectByPicture);
            tab_MainTab.Controls.Add(tbp_DetectRealtime);
            tab_MainTab.Controls.Add(tbp_RegisteredPlates);
            tab_MainTab.Controls.Add(tbp_RegisteredPersons);
            tab_MainTab.Location = new Point(12, 13);
            tab_MainTab.Margin = new Padding(3, 4, 3, 4);
            tab_MainTab.Name = "tab_MainTab";
            tab_MainTab.SelectedIndex = 0;
            tab_MainTab.Size = new Size(982, 703);
            tab_MainTab.TabIndex = 0;
            // 
            // tbp_DetectByPicture
            // 
            tbp_DetectByPicture.Controls.Add(pnl_UserInformation);
            tbp_DetectByPicture.Controls.Add(pnl_PlateDetection);
            tbp_DetectByPicture.Location = new Point(4, 27);
            tbp_DetectByPicture.Margin = new Padding(3, 4, 3, 4);
            tbp_DetectByPicture.Name = "tbp_DetectByPicture";
            tbp_DetectByPicture.Padding = new Padding(3, 4, 3, 4);
            tbp_DetectByPicture.Size = new Size(974, 672);
            tbp_DetectByPicture.TabIndex = 0;
            tbp_DetectByPicture.Text = "شناسایی با عکس";
            tbp_DetectByPicture.UseVisualStyleBackColor = true;
            // 
            // pnl_UserInformation
            // 
            pnl_UserInformation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pnl_UserInformation.Controls.Add(usc_PersonInformation);
            pnl_UserInformation.Location = new Point(478, 7);
            pnl_UserInformation.Name = "pnl_UserInformation";
            pnl_UserInformation.Size = new Size(490, 655);
            pnl_UserInformation.TabIndex = 3;
            // 
            // usc_PersonInformation
            // 
            usc_PersonInformation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            usc_PersonInformation.Font = new Font("IRANSansX", 9F);
            usc_PersonInformation.Location = new Point(3, 4);
            usc_PersonInformation.Margin = new Padding(3, 4, 3, 4);
            usc_PersonInformation.Name = "usc_PersonInformation";
            usc_PersonInformation.Size = new Size(484, 644);
            usc_PersonInformation.TabIndex = 0;
            // 
            // pnl_PlateDetection
            // 
            pnl_PlateDetection.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnl_PlateDetection.Controls.Add(rtb_PlateDetectionLog);
            pnl_PlateDetection.Controls.Add(btn_SelectPlateImage);
            pnl_PlateDetection.Controls.Add(img_PlateImage);
            pnl_PlateDetection.Location = new Point(6, 7);
            pnl_PlateDetection.Margin = new Padding(3, 4, 3, 4);
            pnl_PlateDetection.Name = "pnl_PlateDetection";
            pnl_PlateDetection.Size = new Size(466, 655);
            pnl_PlateDetection.TabIndex = 1;
            // 
            // rtb_PlateDetectionLog
            // 
            rtb_PlateDetectionLog.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtb_PlateDetectionLog.Location = new Point(3, 402);
            rtb_PlateDetectionLog.Name = "rtb_PlateDetectionLog";
            rtb_PlateDetectionLog.Size = new Size(460, 250);
            rtb_PlateDetectionLog.TabIndex = 2;
            rtb_PlateDetectionLog.Text = "";
            // 
            // btn_SelectPlateImage
            // 
            btn_SelectPlateImage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_SelectPlateImage.Location = new Point(3, 315);
            btn_SelectPlateImage.Margin = new Padding(3, 4, 3, 4);
            btn_SelectPlateImage.Name = "btn_SelectPlateImage";
            btn_SelectPlateImage.Size = new Size(460, 43);
            btn_SelectPlateImage.TabIndex = 1;
            btn_SelectPlateImage.Text = "بارگذاری تصویر";
            btn_SelectPlateImage.UseVisualStyleBackColor = true;
            // 
            // img_PlateImage
            // 
            img_PlateImage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            img_PlateImage.Image = Properties.Resources.Default_Pilak;
            img_PlateImage.Location = new Point(3, 4);
            img_PlateImage.Margin = new Padding(3, 4, 3, 4);
            img_PlateImage.Name = "img_PlateImage";
            img_PlateImage.Size = new Size(460, 303);
            img_PlateImage.SizeMode = PictureBoxSizeMode.StretchImage;
            img_PlateImage.TabIndex = 0;
            img_PlateImage.TabStop = false;
            // 
            // tbp_DetectRealtime
            // 
            tbp_DetectRealtime.Controls.Add(pnl_RealTimeDetection);
            tbp_DetectRealtime.Controls.Add(pnl_rtTab_UserInformation);
            tbp_DetectRealtime.Location = new Point(4, 24);
            tbp_DetectRealtime.Margin = new Padding(3, 4, 3, 4);
            tbp_DetectRealtime.Name = "tbp_DetectRealtime";
            tbp_DetectRealtime.Padding = new Padding(3, 4, 3, 4);
            tbp_DetectRealtime.Size = new Size(974, 675);
            tbp_DetectRealtime.TabIndex = 1;
            tbp_DetectRealtime.Text = "شناسایی همزمان";
            tbp_DetectRealtime.UseVisualStyleBackColor = true;
            // 
            // pnl_RealTimeDetection
            // 
            pnl_RealTimeDetection.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnl_RealTimeDetection.Controls.Add(btn_ChooseCamera);
            pnl_RealTimeDetection.Controls.Add(cmb_Cameras);
            pnl_RealTimeDetection.Controls.Add(rtb_RealTimeDetectionLog);
            pnl_RealTimeDetection.Controls.Add(btn_RealTimeDetect);
            pnl_RealTimeDetection.Controls.Add(img_Camera);
            pnl_RealTimeDetection.Location = new Point(6, 7);
            pnl_RealTimeDetection.Name = "pnl_RealTimeDetection";
            pnl_RealTimeDetection.Size = new Size(466, 652);
            pnl_RealTimeDetection.TabIndex = 1;
            // 
            // btn_ChooseCamera
            // 
            btn_ChooseCamera.Location = new Point(433, 371);
            btn_ChooseCamera.Name = "btn_ChooseCamera";
            btn_ChooseCamera.Size = new Size(30, 26);
            btn_ChooseCamera.TabIndex = 4;
            btn_ChooseCamera.Text = "✅";
            btn_ChooseCamera.UseVisualStyleBackColor = true;
            // 
            // cmb_Cameras
            // 
            cmb_Cameras.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmb_Cameras.FormattingEnabled = true;
            cmb_Cameras.Location = new Point(3, 371);
            cmb_Cameras.Name = "cmb_Cameras";
            cmb_Cameras.Size = new Size(427, 26);
            cmb_Cameras.TabIndex = 3;
            // 
            // rtb_RealTimeDetectionLog
            // 
            rtb_RealTimeDetectionLog.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtb_RealTimeDetectionLog.Location = new Point(3, 487);
            rtb_RealTimeDetectionLog.Name = "rtb_RealTimeDetectionLog";
            rtb_RealTimeDetectionLog.Size = new Size(460, 161);
            rtb_RealTimeDetectionLog.TabIndex = 2;
            rtb_RealTimeDetectionLog.Text = "";
            // 
            // btn_RealTimeDetect
            // 
            btn_RealTimeDetect.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_RealTimeDetect.Location = new Point(3, 402);
            btn_RealTimeDetect.Name = "btn_RealTimeDetect";
            btn_RealTimeDetect.Size = new Size(460, 43);
            btn_RealTimeDetect.TabIndex = 1;
            btn_RealTimeDetect.Text = "شناسایی";
            btn_RealTimeDetect.UseVisualStyleBackColor = true;
            // 
            // img_Camera
            // 
            img_Camera.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            img_Camera.BorderStyle = BorderStyle.FixedSingle;
            img_Camera.Location = new Point(3, 4);
            img_Camera.Name = "img_Camera";
            img_Camera.Size = new Size(460, 361);
            img_Camera.TabIndex = 0;
            img_Camera.TabStop = false;
            // 
            // pnl_rtTab_UserInformation
            // 
            pnl_rtTab_UserInformation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pnl_rtTab_UserInformation.Controls.Add(ucPersonInformation1);
            pnl_rtTab_UserInformation.Location = new Point(478, 7);
            pnl_rtTab_UserInformation.Name = "pnl_rtTab_UserInformation";
            pnl_rtTab_UserInformation.Size = new Size(490, 652);
            pnl_rtTab_UserInformation.TabIndex = 0;
            // 
            // ucPersonInformation1
            // 
            ucPersonInformation1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ucPersonInformation1.Font = new Font("IRANSansX", 9F);
            ucPersonInformation1.Location = new Point(3, 4);
            ucPersonInformation1.Margin = new Padding(3, 4, 3, 4);
            ucPersonInformation1.Name = "ucPersonInformation1";
            ucPersonInformation1.Size = new Size(484, 644);
            ucPersonInformation1.TabIndex = 0;
            // 
            // tbp_RegisteredPlates
            // 
            tbp_RegisteredPlates.Controls.Add(pnl_AddPlate);
            tbp_RegisteredPlates.Controls.Add(dgv_Plates);
            tbp_RegisteredPlates.Location = new Point(4, 27);
            tbp_RegisteredPlates.Margin = new Padding(3, 4, 3, 4);
            tbp_RegisteredPlates.Name = "tbp_RegisteredPlates";
            tbp_RegisteredPlates.Size = new Size(974, 672);
            tbp_RegisteredPlates.TabIndex = 2;
            tbp_RegisteredPlates.Text = "پلاک‌های ثبت شده";
            tbp_RegisteredPlates.UseVisualStyleBackColor = true;
            // 
            // pnl_AddPlate
            // 
            pnl_AddPlate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_AddPlate.Controls.Add(lbl_ExpiryDate);
            pnl_AddPlate.Controls.Add(lbl_IssueDate);
            pnl_AddPlate.Controls.Add(dtp_ExpiryDate);
            pnl_AddPlate.Controls.Add(dtp_IssueDate);
            pnl_AddPlate.Controls.Add(cmb_PlatePerson);
            pnl_AddPlate.Controls.Add(btn_AddPlate);
            pnl_AddPlate.Controls.Add(txt_CityCode);
            pnl_AddPlate.Controls.Add(txt_PlateSecondDigit);
            pnl_AddPlate.Controls.Add(cmb_PlateLetter);
            pnl_AddPlate.Controls.Add(txt_PlateFirstDigit);
            pnl_AddPlate.Location = new Point(3, 515);
            pnl_AddPlate.Name = "pnl_AddPlate";
            pnl_AddPlate.Size = new Size(968, 139);
            pnl_AddPlate.TabIndex = 1;
            // 
            // lbl_ExpiryDate
            // 
            lbl_ExpiryDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_ExpiryDate.AutoSize = true;
            lbl_ExpiryDate.Location = new Point(437, 83);
            lbl_ExpiryDate.Name = "lbl_ExpiryDate";
            lbl_ExpiryDate.Size = new Size(39, 18);
            lbl_ExpiryDate.TabIndex = 9;
            lbl_ExpiryDate.Text = "انقضاء";
            // 
            // lbl_IssueDate
            // 
            lbl_IssueDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_IssueDate.AutoSize = true;
            lbl_IssueDate.Location = new Point(574, 83);
            lbl_IssueDate.Name = "lbl_IssueDate";
            lbl_IssueDate.Size = new Size(34, 18);
            lbl_IssueDate.TabIndex = 8;
            lbl_IssueDate.Text = "صدور";
            // 
            // dtp_ExpiryDate
            // 
            dtp_ExpiryDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dtp_ExpiryDate.Format = DateTimePickerFormat.Short;
            dtp_ExpiryDate.Location = new Point(346, 78);
            dtp_ExpiryDate.Name = "dtp_ExpiryDate";
            dtp_ExpiryDate.Size = new Size(85, 25);
            dtp_ExpiryDate.TabIndex = 7;
            // 
            // dtp_IssueDate
            // 
            dtp_IssueDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dtp_IssueDate.Format = DateTimePickerFormat.Short;
            dtp_IssueDate.Location = new Point(482, 78);
            dtp_IssueDate.Name = "dtp_IssueDate";
            dtp_IssueDate.Size = new Size(86, 25);
            dtp_IssueDate.TabIndex = 6;
            // 
            // cmb_PlatePerson
            // 
            cmb_PlatePerson.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cmb_PlatePerson.FormattingEnabled = true;
            cmb_PlatePerson.Location = new Point(346, 13);
            cmb_PlatePerson.Name = "cmb_PlatePerson";
            cmb_PlatePerson.Size = new Size(262, 26);
            cmb_PlatePerson.TabIndex = 5;
            // 
            // btn_AddPlate
            // 
            btn_AddPlate.Anchor = AnchorStyles.Bottom;
            btn_AddPlate.Location = new Point(346, 106);
            btn_AddPlate.Name = "btn_AddPlate";
            btn_AddPlate.Size = new Size(262, 24);
            btn_AddPlate.TabIndex = 4;
            btn_AddPlate.Text = "ثبت پلاک";
            btn_AddPlate.UseVisualStyleBackColor = true;
            // 
            // txt_CityCode
            // 
            txt_CityCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txt_CityCode.Location = new Point(556, 46);
            txt_CityCode.Name = "txt_CityCode";
            txt_CityCode.Size = new Size(52, 25);
            txt_CityCode.TabIndex = 3;
            // 
            // txt_PlateSecondDigit
            // 
            txt_PlateSecondDigit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txt_PlateSecondDigit.Location = new Point(454, 46);
            txt_PlateSecondDigit.Name = "txt_PlateSecondDigit";
            txt_PlateSecondDigit.Size = new Size(96, 25);
            txt_PlateSecondDigit.TabIndex = 2;
            // 
            // cmb_PlateLetter
            // 
            cmb_PlateLetter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cmb_PlateLetter.FormattingEnabled = true;
            cmb_PlateLetter.Items.AddRange(new object[] { "الف", "ب", "پ", "ت", "ث", "ج", "چ", "ح", "خ", "د", "ذ", "ر", "ز", "ژ", "س", "ش", "ص", "ض", "ط", "ظ", "ع", "غ", "ف", "ق", "ک", "گ", "ل", "م", "ن", "و", "ه", "ی" });
            cmb_PlateLetter.Location = new Point(402, 45);
            cmb_PlateLetter.Name = "cmb_PlateLetter";
            cmb_PlateLetter.Size = new Size(46, 26);
            cmb_PlateLetter.TabIndex = 1;
            // 
            // txt_PlateFirstDigit
            // 
            txt_PlateFirstDigit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txt_PlateFirstDigit.Location = new Point(346, 45);
            txt_PlateFirstDigit.Name = "txt_PlateFirstDigit";
            txt_PlateFirstDigit.Size = new Size(50, 25);
            txt_PlateFirstDigit.TabIndex = 0;
            // 
            // dgv_Plates
            // 
            dgv_Plates.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_Plates.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgv_Plates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Plates.Columns.AddRange(new DataGridViewColumn[] { col_plate_Plate, col_plate_IssuedDate, col_plate_ExpiryDate, col_plate_CreatedAt });
            dgv_Plates.Location = new Point(3, 3);
            dgv_Plates.Name = "dgv_Plates";
            dgv_Plates.RightToLeft = RightToLeft.Yes;
            dgv_Plates.Size = new Size(968, 491);
            dgv_Plates.TabIndex = 0;
            // 
            // col_plate_Plate
            // 
            col_plate_Plate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_plate_Plate.HeaderText = "مشخصات پلاک";
            col_plate_Plate.Name = "col_plate_Plate";
            // 
            // col_plate_IssuedDate
            // 
            col_plate_IssuedDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_plate_IssuedDate.HeaderText = "تاریخ صدور";
            col_plate_IssuedDate.Name = "col_plate_IssuedDate";
            // 
            // col_plate_ExpiryDate
            // 
            col_plate_ExpiryDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_plate_ExpiryDate.HeaderText = "تاریخ انقضاء";
            col_plate_ExpiryDate.Name = "col_plate_ExpiryDate";
            // 
            // col_plate_CreatedAt
            // 
            col_plate_CreatedAt.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_plate_CreatedAt.HeaderText = "تاریخ ثبت در سیستم";
            col_plate_CreatedAt.Name = "col_plate_CreatedAt";
            // 
            // tbp_RegisteredPersons
            // 
            tbp_RegisteredPersons.Location = new Point(4, 24);
            tbp_RegisteredPersons.Margin = new Padding(3, 4, 3, 4);
            tbp_RegisteredPersons.Name = "tbp_RegisteredPersons";
            tbp_RegisteredPersons.Size = new Size(974, 675);
            tbp_RegisteredPersons.TabIndex = 3;
            tbp_RegisteredPersons.Text = "شهروندان ثبت شده";
            tbp_RegisteredPersons.UseVisualStyleBackColor = true;
            // 
            // formMain
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 732);
            Controls.Add(tab_MainTab);
            Font = new Font("IRANSansX", 9F, FontStyle.Regular, GraphicsUnit.Point, 178);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "formMain";
            Text = "پیلاک";
            tab_MainTab.ResumeLayout(false);
            tbp_DetectByPicture.ResumeLayout(false);
            pnl_UserInformation.ResumeLayout(false);
            pnl_PlateDetection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)img_PlateImage).EndInit();
            tbp_DetectRealtime.ResumeLayout(false);
            pnl_RealTimeDetection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)img_Camera).EndInit();
            pnl_rtTab_UserInformation.ResumeLayout(false);
            tbp_RegisteredPlates.ResumeLayout(false);
            pnl_AddPlate.ResumeLayout(false);
            pnl_AddPlate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Plates).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tab_MainTab;
        private TabPage tbp_DetectByPicture;
        private TabPage tbp_DetectRealtime;
        private TabPage tbp_RegisteredPlates;
        private TabPage tbp_RegisteredPersons;
        private PictureBox img_PlateImage;
        private Panel pnl_PlateDetection;
        private Button btn_SelectPlateImage;
        private RichTextBox rtb_PlateDetectionLog;
        private Panel pnl_UserInformation;
        private ucPersonInformation usc_PersonInformation;
        private Panel pnl_rtTab_UserInformation;
        private ucPersonInformation ucPersonInformation1;
        private Panel pnl_RealTimeDetection;
        private PictureBox img_Camera;
        private Button btn_RealTimeDetect;
        private RichTextBox rtb_RealTimeDetectionLog;
        private ComboBox cmb_Cameras;
        private Button btn_ChooseCamera;
        private DataGridView dgv_Plates;
        private Panel pnl_AddPlate;
        private ComboBox cmb_PlateLetter;
        private TextBox txt_PlateFirstDigit;
        private TextBox txt_PlateSecondDigit;
        private TextBox txt_CityCode;
        private Button btn_AddPlate;
        private ComboBox cmb_PlatePerson;
        private DataGridViewTextBoxColumn col_plate_Plate;
        private DataGridViewTextBoxColumn col_plate_IssuedDate;
        private DataGridViewTextBoxColumn col_plate_ExpiryDate;
        private DataGridViewTextBoxColumn col_plate_CreatedAt;
        private DateTimePicker dtp_IssueDate;
        private DateTimePicker dtp_ExpiryDate;
        private Label lbl_ExpiryDate;
        private Label lbl_IssueDate;
    }
}
