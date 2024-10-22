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
            tbp_RegisteredPlates = new TabPage();
            tbp_RegisteredPersons = new TabPage();
            tab_MainTab.SuspendLayout();
            tbp_DetectByPicture.SuspendLayout();
            pnl_UserInformation.SuspendLayout();
            pnl_PlateDetection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_PlateImage).BeginInit();
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
            usc_PersonInformation.Location = new Point(3, 1);
            usc_PersonInformation.Margin = new Padding(3, 4, 3, 4);
            usc_PersonInformation.Name = "usc_PersonInformation";
            usc_PersonInformation.Size = new Size(484, 647);
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
            tbp_DetectRealtime.Location = new Point(4, 24);
            tbp_DetectRealtime.Margin = new Padding(3, 4, 3, 4);
            tbp_DetectRealtime.Name = "tbp_DetectRealtime";
            tbp_DetectRealtime.Padding = new Padding(3, 4, 3, 4);
            tbp_DetectRealtime.Size = new Size(974, 675);
            tbp_DetectRealtime.TabIndex = 1;
            tbp_DetectRealtime.Text = "شناسایی همزمان";
            tbp_DetectRealtime.UseVisualStyleBackColor = true;
            // 
            // tbp_RegisteredPlates
            // 
            tbp_RegisteredPlates.Location = new Point(4, 24);
            tbp_RegisteredPlates.Margin = new Padding(3, 4, 3, 4);
            tbp_RegisteredPlates.Name = "tbp_RegisteredPlates";
            tbp_RegisteredPlates.Size = new Size(974, 675);
            tbp_RegisteredPlates.TabIndex = 2;
            tbp_RegisteredPlates.Text = "پلاک‌های ثبت شده";
            tbp_RegisteredPlates.UseVisualStyleBackColor = true;
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
    }
}
