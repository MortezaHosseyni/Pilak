﻿namespace Pilak
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            tab_MainTab = new TabControl();
            tbp_DetectByPicture = new TabPage();
            pnl_UserInformation = new Panel();
            usc_PersonInformation = new UcPersonInformation();
            pnl_PlateDetection = new Panel();
            rtb_PlateDetectionLog = new RichTextBox();
            btn_SelectPlateImage = new Button();
            img_PlateImage = new PictureBox();
            tbp_DetectRealtime = new TabPage();
            pnl_RealTimeDetection = new Panel();
            btn_StartCamera = new Button();
            btn_RefreshCameras = new Button();
            cmb_Cameras = new ComboBox();
            rtb_RealTimeDetectionLog = new RichTextBox();
            btn_RealTimeDetect = new Button();
            img_Camera = new PictureBox();
            pnl_rtTab_UserInformation = new Panel();
            ucPersonInformation1 = new UcPersonInformation();
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
            pnl_AddPerson = new Panel();
            btn_AddPerson = new Button();
            img_PersonImage = new PictureBox();
            rtb_Address = new RichTextBox();
            txt_About = new TextBox();
            txt_Email = new TextBox();
            txt_PhoneNumber = new TextBox();
            txt_FatherName = new TextBox();
            txt_LastName = new TextBox();
            txt_FirstName = new TextBox();
            txt_NationalCode = new TextBox();
            lbl_Address = new Label();
            lbl_About = new Label();
            lbl_Email = new Label();
            lbl_PhoneNumber = new Label();
            lbl_FatherName = new Label();
            lbl_LastName = new Label();
            lbl_FirstName = new Label();
            lbl_NationalCode = new Label();
            dgv_Persons = new DataGridView();
            col_persons_NationalCode = new DataGridViewTextBoxColumn();
            col_persons_FirstName = new DataGridViewTextBoxColumn();
            col_persons_LastName = new DataGridViewTextBoxColumn();
            col_persons_FatherName = new DataGridViewTextBoxColumn();
            col_persons_PhoneNumber = new DataGridViewTextBoxColumn();
            col_persons_Email = new DataGridViewTextBoxColumn();
            col_persons_About = new DataGridViewTextBoxColumn();
            col_persons_Address = new DataGridViewTextBoxColumn();
            btn_AboutUs = new Button();
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
            tbp_RegisteredPersons.SuspendLayout();
            pnl_AddPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_PersonImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Persons).BeginInit();
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
            rtb_PlateDetectionLog.ReadOnly = true;
            rtb_PlateDetectionLog.RightToLeft = RightToLeft.Yes;
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
            btn_SelectPlateImage.Click += btn_SelectPlateImage_Click;
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
            tbp_DetectRealtime.Location = new Point(4, 27);
            tbp_DetectRealtime.Margin = new Padding(3, 4, 3, 4);
            tbp_DetectRealtime.Name = "tbp_DetectRealtime";
            tbp_DetectRealtime.Padding = new Padding(3, 4, 3, 4);
            tbp_DetectRealtime.Size = new Size(974, 672);
            tbp_DetectRealtime.TabIndex = 1;
            tbp_DetectRealtime.Text = "شناسایی همزمان";
            tbp_DetectRealtime.UseVisualStyleBackColor = true;
            tbp_DetectRealtime.Click += tbp_DetectRealtime_Click;
            // 
            // pnl_RealTimeDetection
            // 
            pnl_RealTimeDetection.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnl_RealTimeDetection.Controls.Add(btn_StartCamera);
            pnl_RealTimeDetection.Controls.Add(btn_RefreshCameras);
            pnl_RealTimeDetection.Controls.Add(cmb_Cameras);
            pnl_RealTimeDetection.Controls.Add(rtb_RealTimeDetectionLog);
            pnl_RealTimeDetection.Controls.Add(btn_RealTimeDetect);
            pnl_RealTimeDetection.Controls.Add(img_Camera);
            pnl_RealTimeDetection.Location = new Point(6, 7);
            pnl_RealTimeDetection.Name = "pnl_RealTimeDetection";
            pnl_RealTimeDetection.Size = new Size(466, 655);
            pnl_RealTimeDetection.TabIndex = 1;
            // 
            // btn_StartCamera
            // 
            btn_StartCamera.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_StartCamera.Location = new Point(3, 424);
            btn_StartCamera.Name = "btn_StartCamera";
            btn_StartCamera.Size = new Size(460, 27);
            btn_StartCamera.TabIndex = 5;
            btn_StartCamera.Text = "فعالسازی دوربین";
            btn_StartCamera.UseVisualStyleBackColor = true;
            btn_StartCamera.Click += btn_StartCamera_Click;
            // 
            // btn_RefreshCameras
            // 
            btn_RefreshCameras.Location = new Point(433, 371);
            btn_RefreshCameras.Name = "btn_RefreshCameras";
            btn_RefreshCameras.Size = new Size(30, 26);
            btn_RefreshCameras.TabIndex = 4;
            btn_RefreshCameras.Text = "🔄";
            btn_RefreshCameras.UseVisualStyleBackColor = true;
            btn_RefreshCameras.Click += btn_RefreshCameras_Click;
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
            rtb_RealTimeDetectionLog.Location = new Point(3, 511);
            rtb_RealTimeDetectionLog.Name = "rtb_RealTimeDetectionLog";
            rtb_RealTimeDetectionLog.ReadOnly = true;
            rtb_RealTimeDetectionLog.RightToLeft = RightToLeft.Yes;
            rtb_RealTimeDetectionLog.Size = new Size(460, 140);
            rtb_RealTimeDetectionLog.TabIndex = 2;
            rtb_RealTimeDetectionLog.Text = "";
            // 
            // btn_RealTimeDetect
            // 
            btn_RealTimeDetect.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_RealTimeDetect.Location = new Point(3, 457);
            btn_RealTimeDetect.Name = "btn_RealTimeDetect";
            btn_RealTimeDetect.Size = new Size(460, 27);
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
            pnl_rtTab_UserInformation.Size = new Size(490, 655);
            pnl_rtTab_UserInformation.TabIndex = 0;
            // 
            // ucPersonInformation1
            // 
            ucPersonInformation1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ucPersonInformation1.Font = new Font("IRANSansX", 9F);
            ucPersonInformation1.Location = new Point(3, 4);
            ucPersonInformation1.Margin = new Padding(3, 4, 3, 4);
            ucPersonInformation1.Name = "ucPersonInformation1";
            ucPersonInformation1.Size = new Size(484, 647);
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
            pnl_AddPlate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            pnl_AddPlate.Location = new Point(3, 488);
            pnl_AddPlate.Name = "pnl_AddPlate";
            pnl_AddPlate.Size = new Size(968, 175);
            pnl_AddPlate.TabIndex = 1;
            // 
            // lbl_ExpiryDate
            // 
            lbl_ExpiryDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_ExpiryDate.AutoSize = true;
            lbl_ExpiryDate.Location = new Point(436, 91);
            lbl_ExpiryDate.Name = "lbl_ExpiryDate";
            lbl_ExpiryDate.Size = new Size(39, 18);
            lbl_ExpiryDate.TabIndex = 9;
            lbl_ExpiryDate.Text = "انقضاء";
            // 
            // lbl_IssueDate
            // 
            lbl_IssueDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_IssueDate.AutoSize = true;
            lbl_IssueDate.Location = new Point(573, 91);
            lbl_IssueDate.Name = "lbl_IssueDate";
            lbl_IssueDate.Size = new Size(34, 18);
            lbl_IssueDate.TabIndex = 8;
            lbl_IssueDate.Text = "صدور";
            // 
            // dtp_ExpiryDate
            // 
            dtp_ExpiryDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dtp_ExpiryDate.Format = DateTimePickerFormat.Short;
            dtp_ExpiryDate.Location = new Point(345, 86);
            dtp_ExpiryDate.Name = "dtp_ExpiryDate";
            dtp_ExpiryDate.Size = new Size(85, 25);
            dtp_ExpiryDate.TabIndex = 7;
            // 
            // dtp_IssueDate
            // 
            dtp_IssueDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dtp_IssueDate.Format = DateTimePickerFormat.Short;
            dtp_IssueDate.Location = new Point(481, 86);
            dtp_IssueDate.Name = "dtp_IssueDate";
            dtp_IssueDate.Size = new Size(86, 25);
            dtp_IssueDate.TabIndex = 6;
            // 
            // cmb_PlatePerson
            // 
            cmb_PlatePerson.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cmb_PlatePerson.FormattingEnabled = true;
            cmb_PlatePerson.Location = new Point(345, 21);
            cmb_PlatePerson.Name = "cmb_PlatePerson";
            cmb_PlatePerson.Size = new Size(262, 26);
            cmb_PlatePerson.TabIndex = 5;
            // 
            // btn_AddPlate
            // 
            btn_AddPlate.Anchor = AnchorStyles.Bottom;
            btn_AddPlate.Location = new Point(345, 117);
            btn_AddPlate.Name = "btn_AddPlate";
            btn_AddPlate.Size = new Size(262, 24);
            btn_AddPlate.TabIndex = 4;
            btn_AddPlate.Text = "ثبت پلاک";
            btn_AddPlate.UseVisualStyleBackColor = true;
            // 
            // txt_CityCode
            // 
            txt_CityCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txt_CityCode.Location = new Point(555, 54);
            txt_CityCode.Name = "txt_CityCode";
            txt_CityCode.Size = new Size(52, 25);
            txt_CityCode.TabIndex = 3;
            // 
            // txt_PlateSecondDigit
            // 
            txt_PlateSecondDigit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txt_PlateSecondDigit.Location = new Point(453, 54);
            txt_PlateSecondDigit.Name = "txt_PlateSecondDigit";
            txt_PlateSecondDigit.Size = new Size(96, 25);
            txt_PlateSecondDigit.TabIndex = 2;
            // 
            // cmb_PlateLetter
            // 
            cmb_PlateLetter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cmb_PlateLetter.FormattingEnabled = true;
            cmb_PlateLetter.Items.AddRange(new object[] { "الف", "ب", "پ", "ت", "ث", "ج", "چ", "ح", "خ", "د", "ذ", "ر", "ز", "ژ", "س", "ش", "ص", "ض", "ط", "ظ", "ع", "غ", "ف", "ق", "ک", "گ", "ل", "م", "ن", "و", "ه", "ی" });
            cmb_PlateLetter.Location = new Point(401, 53);
            cmb_PlateLetter.Name = "cmb_PlateLetter";
            cmb_PlateLetter.Size = new Size(46, 26);
            cmb_PlateLetter.TabIndex = 1;
            // 
            // txt_PlateFirstDigit
            // 
            txt_PlateFirstDigit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txt_PlateFirstDigit.Location = new Point(345, 53);
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
            dgv_Plates.Size = new Size(968, 479);
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
            tbp_RegisteredPersons.Controls.Add(pnl_AddPerson);
            tbp_RegisteredPersons.Controls.Add(dgv_Persons);
            tbp_RegisteredPersons.Location = new Point(4, 27);
            tbp_RegisteredPersons.Margin = new Padding(3, 4, 3, 4);
            tbp_RegisteredPersons.Name = "tbp_RegisteredPersons";
            tbp_RegisteredPersons.Size = new Size(974, 672);
            tbp_RegisteredPersons.TabIndex = 3;
            tbp_RegisteredPersons.Text = "شهروندان ثبت شده";
            tbp_RegisteredPersons.UseVisualStyleBackColor = true;
            // 
            // pnl_AddPerson
            // 
            pnl_AddPerson.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_AddPerson.Controls.Add(btn_AddPerson);
            pnl_AddPerson.Controls.Add(img_PersonImage);
            pnl_AddPerson.Controls.Add(rtb_Address);
            pnl_AddPerson.Controls.Add(txt_About);
            pnl_AddPerson.Controls.Add(txt_Email);
            pnl_AddPerson.Controls.Add(txt_PhoneNumber);
            pnl_AddPerson.Controls.Add(txt_FatherName);
            pnl_AddPerson.Controls.Add(txt_LastName);
            pnl_AddPerson.Controls.Add(txt_FirstName);
            pnl_AddPerson.Controls.Add(txt_NationalCode);
            pnl_AddPerson.Controls.Add(lbl_Address);
            pnl_AddPerson.Controls.Add(lbl_About);
            pnl_AddPerson.Controls.Add(lbl_Email);
            pnl_AddPerson.Controls.Add(lbl_PhoneNumber);
            pnl_AddPerson.Controls.Add(lbl_FatherName);
            pnl_AddPerson.Controls.Add(lbl_LastName);
            pnl_AddPerson.Controls.Add(lbl_FirstName);
            pnl_AddPerson.Controls.Add(lbl_NationalCode);
            pnl_AddPerson.Location = new Point(3, 485);
            pnl_AddPerson.Name = "pnl_AddPerson";
            pnl_AddPerson.Size = new Size(968, 169);
            pnl_AddPerson.TabIndex = 1;
            // 
            // btn_AddPerson
            // 
            btn_AddPerson.Anchor = AnchorStyles.Bottom;
            btn_AddPerson.Location = new Point(3, 138);
            btn_AddPerson.Name = "btn_AddPerson";
            btn_AddPerson.Size = new Size(962, 28);
            btn_AddPerson.TabIndex = 17;
            btn_AddPerson.Text = "ثبت اطلاعات";
            btn_AddPerson.UseVisualStyleBackColor = true;
            // 
            // img_PersonImage
            // 
            img_PersonImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            img_PersonImage.Cursor = Cursors.Hand;
            img_PersonImage.Image = Properties.Resources.Default_Person;
            img_PersonImage.Location = new Point(3, 3);
            img_PersonImage.Name = "img_PersonImage";
            img_PersonImage.Size = new Size(131, 115);
            img_PersonImage.SizeMode = PictureBoxSizeMode.StretchImage;
            img_PersonImage.TabIndex = 16;
            img_PersonImage.TabStop = false;
            // 
            // rtb_Address
            // 
            rtb_Address.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            rtb_Address.Location = new Point(140, 3);
            rtb_Address.Name = "rtb_Address";
            rtb_Address.RightToLeft = RightToLeft.Yes;
            rtb_Address.Size = new Size(229, 115);
            rtb_Address.TabIndex = 15;
            rtb_Address.Text = "";
            // 
            // txt_About
            // 
            txt_About.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txt_About.Location = new Point(415, 65);
            txt_About.Multiline = true;
            txt_About.Name = "txt_About";
            txt_About.RightToLeft = RightToLeft.Yes;
            txt_About.Size = new Size(196, 53);
            txt_About.TabIndex = 14;
            // 
            // txt_Email
            // 
            txt_Email.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txt_Email.Location = new Point(415, 34);
            txt_Email.Name = "txt_Email";
            txt_Email.RightToLeft = RightToLeft.Yes;
            txt_Email.Size = new Size(196, 25);
            txt_Email.TabIndex = 13;
            // 
            // txt_PhoneNumber
            // 
            txt_PhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txt_PhoneNumber.Location = new Point(415, 3);
            txt_PhoneNumber.Name = "txt_PhoneNumber";
            txt_PhoneNumber.RightToLeft = RightToLeft.Yes;
            txt_PhoneNumber.Size = new Size(196, 25);
            txt_PhoneNumber.TabIndex = 12;
            // 
            // txt_FatherName
            // 
            txt_FatherName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txt_FatherName.Location = new Point(695, 93);
            txt_FatherName.Name = "txt_FatherName";
            txt_FatherName.RightToLeft = RightToLeft.Yes;
            txt_FatherName.Size = new Size(196, 25);
            txt_FatherName.TabIndex = 11;
            // 
            // txt_LastName
            // 
            txt_LastName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txt_LastName.Location = new Point(695, 62);
            txt_LastName.Name = "txt_LastName";
            txt_LastName.RightToLeft = RightToLeft.Yes;
            txt_LastName.Size = new Size(196, 25);
            txt_LastName.TabIndex = 10;
            // 
            // txt_FirstName
            // 
            txt_FirstName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txt_FirstName.Location = new Point(695, 31);
            txt_FirstName.Name = "txt_FirstName";
            txt_FirstName.RightToLeft = RightToLeft.Yes;
            txt_FirstName.Size = new Size(196, 25);
            txt_FirstName.TabIndex = 9;
            // 
            // txt_NationalCode
            // 
            txt_NationalCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txt_NationalCode.Location = new Point(695, 2);
            txt_NationalCode.Name = "txt_NationalCode";
            txt_NationalCode.RightToLeft = RightToLeft.Yes;
            txt_NationalCode.Size = new Size(196, 25);
            txt_NationalCode.TabIndex = 8;
            // 
            // lbl_Address
            // 
            lbl_Address.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_Address.AutoSize = true;
            lbl_Address.Location = new Point(375, 5);
            lbl_Address.Name = "lbl_Address";
            lbl_Address.RightToLeft = RightToLeft.Yes;
            lbl_Address.Size = new Size(34, 18);
            lbl_Address.TabIndex = 7;
            lbl_Address.Text = "آدرس";
            // 
            // lbl_About
            // 
            lbl_About.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_About.AutoSize = true;
            lbl_About.Location = new Point(617, 65);
            lbl_About.Name = "lbl_About";
            lbl_About.RightToLeft = RightToLeft.Yes;
            lbl_About.Size = new Size(72, 18);
            lbl_About.TabIndex = 6;
            lbl_About.Text = "درباره شهروند";
            // 
            // lbl_Email
            // 
            lbl_Email.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_Email.AutoSize = true;
            lbl_Email.Location = new Point(617, 37);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.RightToLeft = RightToLeft.Yes;
            lbl_Email.Size = new Size(36, 18);
            lbl_Email.TabIndex = 5;
            lbl_Email.Text = "ایمیل";
            // 
            // lbl_PhoneNumber
            // 
            lbl_PhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_PhoneNumber.AutoSize = true;
            lbl_PhoneNumber.Location = new Point(617, 6);
            lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            lbl_PhoneNumber.RightToLeft = RightToLeft.Yes;
            lbl_PhoneNumber.Size = new Size(65, 18);
            lbl_PhoneNumber.TabIndex = 4;
            lbl_PhoneNumber.Text = "شماره همراه";
            // 
            // lbl_FatherName
            // 
            lbl_FatherName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_FatherName.AutoSize = true;
            lbl_FatherName.Location = new Point(897, 96);
            lbl_FatherName.Name = "lbl_FatherName";
            lbl_FatherName.RightToLeft = RightToLeft.Yes;
            lbl_FatherName.Size = new Size(41, 18);
            lbl_FatherName.TabIndex = 3;
            lbl_FatherName.Text = "نام پدر";
            // 
            // lbl_LastName
            // 
            lbl_LastName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_LastName.AutoSize = true;
            lbl_LastName.Location = new Point(897, 65);
            lbl_LastName.Name = "lbl_LastName";
            lbl_LastName.RightToLeft = RightToLeft.Yes;
            lbl_LastName.Size = new Size(68, 18);
            lbl_LastName.TabIndex = 2;
            lbl_LastName.Text = "نام خانوادگی";
            // 
            // lbl_FirstName
            // 
            lbl_FirstName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_FirstName.AutoSize = true;
            lbl_FirstName.Location = new Point(897, 34);
            lbl_FirstName.Name = "lbl_FirstName";
            lbl_FirstName.RightToLeft = RightToLeft.Yes;
            lbl_FirstName.Size = new Size(22, 18);
            lbl_FirstName.TabIndex = 1;
            lbl_FirstName.Text = "نام";
            // 
            // lbl_NationalCode
            // 
            lbl_NationalCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_NationalCode.AutoSize = true;
            lbl_NationalCode.Location = new Point(897, 9);
            lbl_NationalCode.Name = "lbl_NationalCode";
            lbl_NationalCode.RightToLeft = RightToLeft.Yes;
            lbl_NationalCode.Size = new Size(38, 18);
            lbl_NationalCode.TabIndex = 0;
            lbl_NationalCode.Text = "کدملی";
            // 
            // dgv_Persons
            // 
            dgv_Persons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_Persons.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgv_Persons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Persons.Columns.AddRange(new DataGridViewColumn[] { col_persons_NationalCode, col_persons_FirstName, col_persons_LastName, col_persons_FatherName, col_persons_PhoneNumber, col_persons_Email, col_persons_About, col_persons_Address });
            dgv_Persons.Location = new Point(3, 3);
            dgv_Persons.Name = "dgv_Persons";
            dgv_Persons.RightToLeft = RightToLeft.Yes;
            dgv_Persons.Size = new Size(968, 479);
            dgv_Persons.TabIndex = 0;
            // 
            // col_persons_NationalCode
            // 
            col_persons_NationalCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_persons_NationalCode.HeaderText = "کدملی";
            col_persons_NationalCode.Name = "col_persons_NationalCode";
            // 
            // col_persons_FirstName
            // 
            col_persons_FirstName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_persons_FirstName.HeaderText = "نام";
            col_persons_FirstName.Name = "col_persons_FirstName";
            // 
            // col_persons_LastName
            // 
            col_persons_LastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_persons_LastName.HeaderText = "نام خانوادگی";
            col_persons_LastName.Name = "col_persons_LastName";
            // 
            // col_persons_FatherName
            // 
            col_persons_FatherName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_persons_FatherName.HeaderText = "نام پدر";
            col_persons_FatherName.Name = "col_persons_FatherName";
            // 
            // col_persons_PhoneNumber
            // 
            col_persons_PhoneNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_persons_PhoneNumber.HeaderText = "شماره همراه";
            col_persons_PhoneNumber.Name = "col_persons_PhoneNumber";
            // 
            // col_persons_Email
            // 
            col_persons_Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_persons_Email.HeaderText = "ایمیل";
            col_persons_Email.Name = "col_persons_Email";
            // 
            // col_persons_About
            // 
            col_persons_About.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_persons_About.HeaderText = "درباره";
            col_persons_About.Name = "col_persons_About";
            // 
            // col_persons_Address
            // 
            col_persons_Address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_persons_Address.HeaderText = "آدرس";
            col_persons_Address.Name = "col_persons_Address";
            // 
            // btn_AboutUs
            // 
            btn_AboutUs.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_AboutUs.Location = new Point(956, 4);
            btn_AboutUs.Name = "btn_AboutUs";
            btn_AboutUs.Size = new Size(34, 29);
            btn_AboutUs.TabIndex = 1;
            btn_AboutUs.Text = "❕";
            btn_AboutUs.UseVisualStyleBackColor = true;
            btn_AboutUs.Click += btn_AboutUs_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 732);
            Controls.Add(btn_AboutUs);
            Controls.Add(tab_MainTab);
            Font = new Font("IRANSansX", 9F, FontStyle.Regular, GraphicsUnit.Point, 178);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "پیلاک";
            FormClosing += FormMain_FormClosing;
            Load += FormMain_Load;
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
            tbp_RegisteredPersons.ResumeLayout(false);
            pnl_AddPerson.ResumeLayout(false);
            pnl_AddPerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)img_PersonImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Persons).EndInit();
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
        private UcPersonInformation usc_PersonInformation;
        private Panel pnl_rtTab_UserInformation;
        private UcPersonInformation ucPersonInformation1;
        private Panel pnl_RealTimeDetection;
        private PictureBox img_Camera;
        private Button btn_RealTimeDetect;
        private RichTextBox rtb_RealTimeDetectionLog;
        private ComboBox cmb_Cameras;
        private Button btn_RefreshCameras;
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
        private DataGridView dgv_Persons;
        private Panel pnl_AddPerson;
        private Label lbl_NationalCode;
        private Label lbl_FatherName;
        private Label lbl_LastName;
        private Label lbl_FirstName;
        private Label lbl_PhoneNumber;
        private Label lbl_Email;
        private Label lbl_About;
        private Label lbl_Address;
        private TextBox txt_NationalCode;
        private TextBox txt_FatherName;
        private TextBox txt_LastName;
        private TextBox txt_FirstName;
        private TextBox txt_Email;
        private TextBox txt_PhoneNumber;
        private TextBox txt_About;
        private RichTextBox rtb_Address;
        private PictureBox img_PersonImage;
        private Button btn_AddPerson;
        private DataGridViewTextBoxColumn col_persons_NationalCode;
        private DataGridViewTextBoxColumn col_persons_FirstName;
        private DataGridViewTextBoxColumn col_persons_LastName;
        private DataGridViewTextBoxColumn col_persons_FatherName;
        private DataGridViewTextBoxColumn col_persons_PhoneNumber;
        private DataGridViewTextBoxColumn col_persons_Email;
        private DataGridViewTextBoxColumn col_persons_About;
        private DataGridViewTextBoxColumn col_persons_Address;
        private Button btn_AboutUs;
        private Button btn_StartCamera;
    }
}
