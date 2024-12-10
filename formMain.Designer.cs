namespace Pilak
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            tab_MainTab = new TabControl();
            tbp_DetectByPicture = new TabPage();
            pnl_PlateDetection = new Panel();
            img_PlateContent = new PictureBox();
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
            tbp_RegisteredPlates = new TabPage();
            pnl_AddPlate = new Panel();
            btn_CancelPlateEdit = new Button();
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
            col_plate_Id = new DataGridViewTextBoxColumn();
            col_plate_Plate = new DataGridViewTextBoxColumn();
            col_plate_Person = new DataGridViewTextBoxColumn();
            col_plate_IssuedDate = new DataGridViewTextBoxColumn();
            col_plate_ExpiryDate = new DataGridViewTextBoxColumn();
            col_plate_CreatedAt = new DataGridViewTextBoxColumn();
            col_plate_PersonId = new DataGridViewTextBoxColumn();
            cms_PlatesTable = new ContextMenuStrip(components);
            btn_DeletePlate = new ToolStripMenuItem();
            btn_EditPlate = new ToolStripMenuItem();
            tbp_RegisteredPersons = new TabPage();
            pnl_AddPerson = new Panel();
            btn_CancelPersonEdit = new Button();
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
            btn_PersonInfo = new Button();
            cms_PersonsTable = new ContextMenuStrip(components);
            btn_DeletePerson = new ToolStripMenuItem();
            btn_EditPerson = new ToolStripMenuItem();
            tab_MainTab.SuspendLayout();
            tbp_DetectByPicture.SuspendLayout();
            pnl_PlateDetection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_PlateContent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_PlateImage).BeginInit();
            tbp_DetectRealtime.SuspendLayout();
            pnl_RealTimeDetection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_Camera).BeginInit();
            tbp_RegisteredPlates.SuspendLayout();
            pnl_AddPlate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Plates).BeginInit();
            cms_PlatesTable.SuspendLayout();
            tbp_RegisteredPersons.SuspendLayout();
            pnl_AddPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_PersonImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Persons).BeginInit();
            cms_PersonsTable.SuspendLayout();
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
            // pnl_PlateDetection
            // 
            pnl_PlateDetection.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_PlateDetection.Controls.Add(img_PlateContent);
            pnl_PlateDetection.Controls.Add(rtb_PlateDetectionLog);
            pnl_PlateDetection.Controls.Add(btn_SelectPlateImage);
            pnl_PlateDetection.Controls.Add(img_PlateImage);
            pnl_PlateDetection.Location = new Point(6, 7);
            pnl_PlateDetection.Margin = new Padding(3, 4, 3, 4);
            pnl_PlateDetection.Name = "pnl_PlateDetection";
            pnl_PlateDetection.Size = new Size(962, 655);
            pnl_PlateDetection.TabIndex = 1;
            // 
            // img_PlateContent
            // 
            img_PlateContent.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            img_PlateContent.BorderStyle = BorderStyle.FixedSingle;
            img_PlateContent.Location = new Point(7, 419);
            img_PlateContent.Name = "img_PlateContent";
            img_PlateContent.Size = new Size(211, 55);
            img_PlateContent.SizeMode = PictureBoxSizeMode.StretchImage;
            img_PlateContent.TabIndex = 3;
            img_PlateContent.TabStop = false;
            img_PlateContent.Visible = false;
            // 
            // rtb_PlateDetectionLog
            // 
            rtb_PlateDetectionLog.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtb_PlateDetectionLog.Location = new Point(3, 536);
            rtb_PlateDetectionLog.Name = "rtb_PlateDetectionLog";
            rtb_PlateDetectionLog.ReadOnly = true;
            rtb_PlateDetectionLog.RightToLeft = RightToLeft.Yes;
            rtb_PlateDetectionLog.Size = new Size(956, 116);
            rtb_PlateDetectionLog.TabIndex = 2;
            rtb_PlateDetectionLog.Text = "";
            // 
            // btn_SelectPlateImage
            // 
            btn_SelectPlateImage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_SelectPlateImage.Location = new Point(6, 486);
            btn_SelectPlateImage.Margin = new Padding(3, 4, 3, 4);
            btn_SelectPlateImage.Name = "btn_SelectPlateImage";
            btn_SelectPlateImage.Size = new Size(953, 43);
            btn_SelectPlateImage.TabIndex = 1;
            btn_SelectPlateImage.Text = "بارگذاری تصویر";
            btn_SelectPlateImage.UseVisualStyleBackColor = true;
            btn_SelectPlateImage.Click += btn_SelectPlateImage_Click;
            // 
            // img_PlateImage
            // 
            img_PlateImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            img_PlateImage.BorderStyle = BorderStyle.FixedSingle;
            img_PlateImage.Image = Properties.Resources.Default_Pilak;
            img_PlateImage.Location = new Point(3, 4);
            img_PlateImage.Margin = new Padding(3, 4, 3, 4);
            img_PlateImage.Name = "img_PlateImage";
            img_PlateImage.Size = new Size(956, 474);
            img_PlateImage.SizeMode = PictureBoxSizeMode.CenterImage;
            img_PlateImage.TabIndex = 0;
            img_PlateImage.TabStop = false;
            // 
            // tbp_DetectRealtime
            // 
            tbp_DetectRealtime.Controls.Add(pnl_RealTimeDetection);
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
            pnl_RealTimeDetection.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_RealTimeDetection.Controls.Add(btn_StartCamera);
            pnl_RealTimeDetection.Controls.Add(btn_RefreshCameras);
            pnl_RealTimeDetection.Controls.Add(cmb_Cameras);
            pnl_RealTimeDetection.Controls.Add(rtb_RealTimeDetectionLog);
            pnl_RealTimeDetection.Controls.Add(btn_RealTimeDetect);
            pnl_RealTimeDetection.Controls.Add(img_Camera);
            pnl_RealTimeDetection.Location = new Point(6, 7);
            pnl_RealTimeDetection.Name = "pnl_RealTimeDetection";
            pnl_RealTimeDetection.Size = new Size(962, 637);
            pnl_RealTimeDetection.TabIndex = 1;
            // 
            // btn_StartCamera
            // 
            btn_StartCamera.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_StartCamera.Location = new Point(3, 456);
            btn_StartCamera.Name = "btn_StartCamera";
            btn_StartCamera.Size = new Size(956, 27);
            btn_StartCamera.TabIndex = 5;
            btn_StartCamera.Text = "فعالسازی دوربین";
            btn_StartCamera.UseVisualStyleBackColor = true;
            btn_StartCamera.Click += btn_StartCamera_Click;
            // 
            // btn_RefreshCameras
            // 
            btn_RefreshCameras.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_RefreshCameras.Location = new Point(929, 424);
            btn_RefreshCameras.Name = "btn_RefreshCameras";
            btn_RefreshCameras.Size = new Size(30, 26);
            btn_RefreshCameras.TabIndex = 4;
            btn_RefreshCameras.Text = "🔄";
            btn_RefreshCameras.UseVisualStyleBackColor = true;
            btn_RefreshCameras.Click += btn_RefreshCameras_Click;
            // 
            // cmb_Cameras
            // 
            cmb_Cameras.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmb_Cameras.FormattingEnabled = true;
            cmb_Cameras.Location = new Point(3, 424);
            cmb_Cameras.Name = "cmb_Cameras";
            cmb_Cameras.Size = new Size(920, 26);
            cmb_Cameras.TabIndex = 3;
            // 
            // rtb_RealTimeDetectionLog
            // 
            rtb_RealTimeDetectionLog.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtb_RealTimeDetectionLog.Location = new Point(3, 522);
            rtb_RealTimeDetectionLog.Name = "rtb_RealTimeDetectionLog";
            rtb_RealTimeDetectionLog.ReadOnly = true;
            rtb_RealTimeDetectionLog.RightToLeft = RightToLeft.Yes;
            rtb_RealTimeDetectionLog.Size = new Size(956, 111);
            rtb_RealTimeDetectionLog.TabIndex = 2;
            rtb_RealTimeDetectionLog.Text = "";
            // 
            // btn_RealTimeDetect
            // 
            btn_RealTimeDetect.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_RealTimeDetect.Location = new Point(3, 489);
            btn_RealTimeDetect.Name = "btn_RealTimeDetect";
            btn_RealTimeDetect.Size = new Size(956, 27);
            btn_RealTimeDetect.TabIndex = 1;
            btn_RealTimeDetect.Text = "شناسایی";
            btn_RealTimeDetect.UseVisualStyleBackColor = true;
            // 
            // img_Camera
            // 
            img_Camera.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            img_Camera.BorderStyle = BorderStyle.FixedSingle;
            img_Camera.Location = new Point(3, 4);
            img_Camera.Name = "img_Camera";
            img_Camera.Size = new Size(956, 414);
            img_Camera.TabIndex = 0;
            img_Camera.TabStop = false;
            // 
            // tbp_RegisteredPlates
            // 
            tbp_RegisteredPlates.Controls.Add(pnl_AddPlate);
            tbp_RegisteredPlates.Controls.Add(dgv_Plates);
            tbp_RegisteredPlates.Location = new Point(4, 24);
            tbp_RegisteredPlates.Margin = new Padding(3, 4, 3, 4);
            tbp_RegisteredPlates.Name = "tbp_RegisteredPlates";
            tbp_RegisteredPlates.Size = new Size(974, 675);
            tbp_RegisteredPlates.TabIndex = 2;
            tbp_RegisteredPlates.Text = "پلاک‌های ثبت شده";
            tbp_RegisteredPlates.UseVisualStyleBackColor = true;
            // 
            // pnl_AddPlate
            // 
            pnl_AddPlate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_AddPlate.Controls.Add(btn_CancelPlateEdit);
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
            pnl_AddPlate.Location = new Point(3, 496);
            pnl_AddPlate.Name = "pnl_AddPlate";
            pnl_AddPlate.Size = new Size(968, 152);
            pnl_AddPlate.TabIndex = 1;
            // 
            // btn_CancelPlateEdit
            // 
            btn_CancelPlateEdit.Anchor = AnchorStyles.Bottom;
            btn_CancelPlateEdit.BackColor = Color.FromArgb(255, 255, 192);
            btn_CancelPlateEdit.Location = new Point(613, 118);
            btn_CancelPlateEdit.Name = "btn_CancelPlateEdit";
            btn_CancelPlateEdit.Size = new Size(51, 23);
            btn_CancelPlateEdit.TabIndex = 10;
            btn_CancelPlateEdit.Text = "انصراف";
            btn_CancelPlateEdit.UseVisualStyleBackColor = false;
            btn_CancelPlateEdit.Visible = false;
            btn_CancelPlateEdit.Click += btn_CancelPlateEdit_Click;
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
            btn_AddPlate.Click += btn_AddPlate_Click;
            // 
            // txt_CityCode
            // 
            txt_CityCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txt_CityCode.Location = new Point(555, 54);
            txt_CityCode.MaxLength = 2;
            txt_CityCode.Name = "txt_CityCode";
            txt_CityCode.Size = new Size(52, 25);
            txt_CityCode.TabIndex = 3;
            txt_CityCode.KeyPress += txt_CityCode_KeyPress;
            // 
            // txt_PlateSecondDigit
            // 
            txt_PlateSecondDigit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txt_PlateSecondDigit.Location = new Point(453, 54);
            txt_PlateSecondDigit.MaxLength = 3;
            txt_PlateSecondDigit.Name = "txt_PlateSecondDigit";
            txt_PlateSecondDigit.Size = new Size(96, 25);
            txt_PlateSecondDigit.TabIndex = 2;
            txt_PlateSecondDigit.KeyPress += txt_PlateSecondDigit_KeyPress;
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
            txt_PlateFirstDigit.MaxLength = 2;
            txt_PlateFirstDigit.Name = "txt_PlateFirstDigit";
            txt_PlateFirstDigit.Size = new Size(50, 25);
            txt_PlateFirstDigit.TabIndex = 0;
            txt_PlateFirstDigit.KeyPress += txt_PlateFirstDigit_KeyPress;
            // 
            // dgv_Plates
            // 
            dgv_Plates.AllowUserToAddRows = false;
            dgv_Plates.AllowUserToDeleteRows = false;
            dgv_Plates.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_Plates.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgv_Plates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Plates.Columns.AddRange(new DataGridViewColumn[] { col_plate_Id, col_plate_Plate, col_plate_Person, col_plate_IssuedDate, col_plate_ExpiryDate, col_plate_CreatedAt, col_plate_PersonId });
            dgv_Plates.ContextMenuStrip = cms_PlatesTable;
            dgv_Plates.Location = new Point(3, 3);
            dgv_Plates.MultiSelect = false;
            dgv_Plates.Name = "dgv_Plates";
            dgv_Plates.RightToLeft = RightToLeft.Yes;
            dgv_Plates.Size = new Size(968, 487);
            dgv_Plates.TabIndex = 0;
            // 
            // col_plate_Id
            // 
            col_plate_Id.HeaderText = "Id";
            col_plate_Id.Name = "col_plate_Id";
            col_plate_Id.Visible = false;
            // 
            // col_plate_Plate
            // 
            col_plate_Plate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_plate_Plate.HeaderText = "مشخصات پلاک";
            col_plate_Plate.Name = "col_plate_Plate";
            // 
            // col_plate_Person
            // 
            col_plate_Person.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col_plate_Person.HeaderText = "به نام";
            col_plate_Person.Name = "col_plate_Person";
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
            // col_plate_PersonId
            // 
            col_plate_PersonId.HeaderText = "PersonId";
            col_plate_PersonId.Name = "col_plate_PersonId";
            col_plate_PersonId.Visible = false;
            // 
            // cms_PlatesTable
            // 
            cms_PlatesTable.Items.AddRange(new ToolStripItem[] { btn_DeletePlate, btn_EditPlate });
            cms_PlatesTable.Name = "cms_PlatesTable";
            cms_PlatesTable.Size = new Size(111, 48);
            // 
            // btn_DeletePlate
            // 
            btn_DeletePlate.BackColor = Color.FromArgb(255, 192, 192);
            btn_DeletePlate.Name = "btn_DeletePlate";
            btn_DeletePlate.Size = new Size(110, 22);
            btn_DeletePlate.Text = "حذف";
            // 
            // btn_EditPlate
            // 
            btn_EditPlate.Name = "btn_EditPlate";
            btn_EditPlate.Size = new Size(110, 22);
            btn_EditPlate.Text = "ویرایش";
            btn_EditPlate.Click += btn_EditPlate_Click;
            // 
            // tbp_RegisteredPersons
            // 
            tbp_RegisteredPersons.Controls.Add(pnl_AddPerson);
            tbp_RegisteredPersons.Controls.Add(dgv_Persons);
            tbp_RegisteredPersons.Location = new Point(4, 24);
            tbp_RegisteredPersons.Margin = new Padding(3, 4, 3, 4);
            tbp_RegisteredPersons.Name = "tbp_RegisteredPersons";
            tbp_RegisteredPersons.Size = new Size(974, 675);
            tbp_RegisteredPersons.TabIndex = 3;
            tbp_RegisteredPersons.Text = "شهروندان ثبت شده";
            tbp_RegisteredPersons.UseVisualStyleBackColor = true;
            // 
            // pnl_AddPerson
            // 
            pnl_AddPerson.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_AddPerson.Controls.Add(btn_CancelPersonEdit);
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
            pnl_AddPerson.Location = new Point(3, 479);
            pnl_AddPerson.Name = "pnl_AddPerson";
            pnl_AddPerson.Size = new Size(968, 169);
            pnl_AddPerson.TabIndex = 1;
            // 
            // btn_CancelPersonEdit
            // 
            btn_CancelPersonEdit.BackColor = Color.FromArgb(255, 255, 192);
            btn_CancelPersonEdit.Location = new Point(897, 131);
            btn_CancelPersonEdit.Name = "btn_CancelPersonEdit";
            btn_CancelPersonEdit.Size = new Size(68, 28);
            btn_CancelPersonEdit.TabIndex = 18;
            btn_CancelPersonEdit.Text = "انصراف";
            btn_CancelPersonEdit.UseVisualStyleBackColor = false;
            btn_CancelPersonEdit.Visible = false;
            // 
            // btn_AddPerson
            // 
            btn_AddPerson.Anchor = AnchorStyles.Bottom;
            btn_AddPerson.Location = new Point(140, 131);
            btn_AddPerson.Name = "btn_AddPerson";
            btn_AddPerson.Size = new Size(751, 28);
            btn_AddPerson.TabIndex = 17;
            btn_AddPerson.Text = "ثبت اطلاعات";
            btn_AddPerson.UseVisualStyleBackColor = true;
            btn_AddPerson.Click += btn_AddPerson_Click;
            // 
            // img_PersonImage
            // 
            img_PersonImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            img_PersonImage.Cursor = Cursors.Hand;
            img_PersonImage.Image = Properties.Resources.Default_Person;
            img_PersonImage.Location = new Point(3, 10);
            img_PersonImage.Name = "img_PersonImage";
            img_PersonImage.Size = new Size(131, 115);
            img_PersonImage.SizeMode = PictureBoxSizeMode.StretchImage;
            img_PersonImage.TabIndex = 16;
            img_PersonImage.TabStop = false;
            img_PersonImage.Click += img_PersonImage_Click;
            // 
            // rtb_Address
            // 
            rtb_Address.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            rtb_Address.Location = new Point(140, 10);
            rtb_Address.Name = "rtb_Address";
            rtb_Address.RightToLeft = RightToLeft.Yes;
            rtb_Address.Size = new Size(229, 115);
            rtb_Address.TabIndex = 15;
            rtb_Address.Text = "";
            // 
            // txt_About
            // 
            txt_About.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txt_About.Location = new Point(415, 72);
            txt_About.Multiline = true;
            txt_About.Name = "txt_About";
            txt_About.RightToLeft = RightToLeft.Yes;
            txt_About.Size = new Size(196, 53);
            txt_About.TabIndex = 14;
            // 
            // txt_Email
            // 
            txt_Email.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txt_Email.Location = new Point(415, 41);
            txt_Email.Name = "txt_Email";
            txt_Email.RightToLeft = RightToLeft.Yes;
            txt_Email.Size = new Size(196, 25);
            txt_Email.TabIndex = 13;
            // 
            // txt_PhoneNumber
            // 
            txt_PhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txt_PhoneNumber.Location = new Point(415, 10);
            txt_PhoneNumber.Name = "txt_PhoneNumber";
            txt_PhoneNumber.RightToLeft = RightToLeft.Yes;
            txt_PhoneNumber.Size = new Size(196, 25);
            txt_PhoneNumber.TabIndex = 12;
            // 
            // txt_FatherName
            // 
            txt_FatherName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txt_FatherName.Location = new Point(695, 100);
            txt_FatherName.Name = "txt_FatherName";
            txt_FatherName.RightToLeft = RightToLeft.Yes;
            txt_FatherName.Size = new Size(196, 25);
            txt_FatherName.TabIndex = 11;
            // 
            // txt_LastName
            // 
            txt_LastName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txt_LastName.Location = new Point(695, 69);
            txt_LastName.Name = "txt_LastName";
            txt_LastName.RightToLeft = RightToLeft.Yes;
            txt_LastName.Size = new Size(196, 25);
            txt_LastName.TabIndex = 10;
            // 
            // txt_FirstName
            // 
            txt_FirstName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txt_FirstName.Location = new Point(695, 38);
            txt_FirstName.Name = "txt_FirstName";
            txt_FirstName.RightToLeft = RightToLeft.Yes;
            txt_FirstName.Size = new Size(196, 25);
            txt_FirstName.TabIndex = 9;
            // 
            // txt_NationalCode
            // 
            txt_NationalCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txt_NationalCode.Location = new Point(695, 9);
            txt_NationalCode.Name = "txt_NationalCode";
            txt_NationalCode.RightToLeft = RightToLeft.Yes;
            txt_NationalCode.Size = new Size(196, 25);
            txt_NationalCode.TabIndex = 8;
            // 
            // lbl_Address
            // 
            lbl_Address.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_Address.AutoSize = true;
            lbl_Address.Location = new Point(375, 12);
            lbl_Address.Name = "lbl_Address";
            lbl_Address.RightToLeft = RightToLeft.Yes;
            lbl_Address.Size = new Size(34, 18);
            lbl_Address.TabIndex = 7;
            lbl_Address.Text = "آدرس";
            // 
            // lbl_About
            // 
            lbl_About.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_About.AutoSize = true;
            lbl_About.Location = new Point(617, 72);
            lbl_About.Name = "lbl_About";
            lbl_About.RightToLeft = RightToLeft.Yes;
            lbl_About.Size = new Size(72, 18);
            lbl_About.TabIndex = 6;
            lbl_About.Text = "درباره شهروند";
            // 
            // lbl_Email
            // 
            lbl_Email.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_Email.AutoSize = true;
            lbl_Email.Location = new Point(617, 44);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.RightToLeft = RightToLeft.Yes;
            lbl_Email.Size = new Size(36, 18);
            lbl_Email.TabIndex = 5;
            lbl_Email.Text = "ایمیل";
            // 
            // lbl_PhoneNumber
            // 
            lbl_PhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_PhoneNumber.AutoSize = true;
            lbl_PhoneNumber.Location = new Point(617, 13);
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
            lbl_FatherName.Location = new Point(897, 103);
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
            lbl_LastName.Location = new Point(897, 72);
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
            lbl_FirstName.Location = new Point(897, 41);
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
            lbl_NationalCode.Location = new Point(897, 16);
            lbl_NationalCode.Name = "lbl_NationalCode";
            lbl_NationalCode.RightToLeft = RightToLeft.Yes;
            lbl_NationalCode.Size = new Size(38, 18);
            lbl_NationalCode.TabIndex = 0;
            lbl_NationalCode.Text = "کدملی";
            // 
            // dgv_Persons
            // 
            dgv_Persons.AllowUserToAddRows = false;
            dgv_Persons.AllowUserToDeleteRows = false;
            dgv_Persons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_Persons.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgv_Persons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Persons.Columns.AddRange(new DataGridViewColumn[] { col_persons_NationalCode, col_persons_FirstName, col_persons_LastName, col_persons_FatherName, col_persons_PhoneNumber, col_persons_Email, col_persons_About, col_persons_Address });
            dgv_Persons.Location = new Point(3, 3);
            dgv_Persons.Name = "dgv_Persons";
            dgv_Persons.RightToLeft = RightToLeft.Yes;
            dgv_Persons.Size = new Size(968, 470);
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
            // btn_PersonInfo
            // 
            btn_PersonInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_PersonInfo.Location = new Point(916, 4);
            btn_PersonInfo.Name = "btn_PersonInfo";
            btn_PersonInfo.Size = new Size(34, 29);
            btn_PersonInfo.TabIndex = 2;
            btn_PersonInfo.Text = "👤";
            btn_PersonInfo.UseVisualStyleBackColor = true;
            btn_PersonInfo.Click += btn_PersonInfo_Click;
            // 
            // cms_PersonsTable
            // 
            cms_PersonsTable.Items.AddRange(new ToolStripItem[] { btn_DeletePerson, btn_EditPerson });
            cms_PersonsTable.Name = "cms_PersonsTable";
            cms_PersonsTable.Size = new Size(111, 48);
            // 
            // btn_DeletePerson
            // 
            btn_DeletePerson.BackColor = Color.FromArgb(255, 192, 192);
            btn_DeletePerson.Name = "btn_DeletePerson";
            btn_DeletePerson.Size = new Size(110, 22);
            btn_DeletePerson.Text = "حذف";
            // 
            // btn_EditPerson
            // 
            btn_EditPerson.Name = "btn_EditPerson";
            btn_EditPerson.Size = new Size(110, 22);
            btn_EditPerson.Text = "ویرایش";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 732);
            Controls.Add(btn_PersonInfo);
            Controls.Add(btn_AboutUs);
            Controls.Add(tab_MainTab);
            Font = new Font("IRANSansX", 9F, FontStyle.Regular, GraphicsUnit.Point, 178);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "پیلاک";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormMain_FormClosing;
            Load += FormMain_Load;
            tab_MainTab.ResumeLayout(false);
            tbp_DetectByPicture.ResumeLayout(false);
            pnl_PlateDetection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)img_PlateContent).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_PlateImage).EndInit();
            tbp_DetectRealtime.ResumeLayout(false);
            pnl_RealTimeDetection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)img_Camera).EndInit();
            tbp_RegisteredPlates.ResumeLayout(false);
            pnl_AddPlate.ResumeLayout(false);
            pnl_AddPlate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Plates).EndInit();
            cms_PlatesTable.ResumeLayout(false);
            tbp_RegisteredPersons.ResumeLayout(false);
            pnl_AddPerson.ResumeLayout(false);
            pnl_AddPerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)img_PersonImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Persons).EndInit();
            cms_PersonsTable.ResumeLayout(false);
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
        private PictureBox img_PlateContent;
        private DataGridViewTextBoxColumn col_plate_Id;
        private DataGridViewTextBoxColumn col_plate_Plate;
        private DataGridViewTextBoxColumn col_plate_Person;
        private DataGridViewTextBoxColumn col_plate_IssuedDate;
        private DataGridViewTextBoxColumn col_plate_ExpiryDate;
        private DataGridViewTextBoxColumn col_plate_CreatedAt;
        private DataGridViewTextBoxColumn col_plate_PersonId;
        private Button btn_PersonInfo;
        private ContextMenuStrip cms_PlatesTable;
        private ContextMenuStrip cms_PersonsTable;
        private ToolStripMenuItem btn_DeletePlate;
        private ToolStripMenuItem btn_EditPlate;
        private ToolStripMenuItem btn_DeletePerson;
        private ToolStripMenuItem btn_EditPerson;
        private Button btn_CancelPlateEdit;
        private Button btn_CancelPersonEdit;
    }
}
