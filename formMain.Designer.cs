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
            tbp_DetectRealtime = new TabPage();
            tbp_RegisteredPlates = new TabPage();
            tbp_RegisteredPersons = new TabPage();
            tab_MainTab.SuspendLayout();
            SuspendLayout();
            // 
            // tab_MainTab
            // 
            tab_MainTab.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tab_MainTab.Controls.Add(tbp_DetectByPicture);
            tab_MainTab.Controls.Add(tbp_DetectRealtime);
            tab_MainTab.Controls.Add(tbp_RegisteredPlates);
            tab_MainTab.Controls.Add(tbp_RegisteredPersons);
            tab_MainTab.Location = new Point(12, 12);
            tab_MainTab.Name = "tab_MainTab";
            tab_MainTab.SelectedIndex = 0;
            tab_MainTab.Size = new Size(982, 586);
            tab_MainTab.TabIndex = 0;
            // 
            // tbp_DetectByPicture
            // 
            tbp_DetectByPicture.Location = new Point(4, 24);
            tbp_DetectByPicture.Name = "tbp_DetectByPicture";
            tbp_DetectByPicture.Padding = new Padding(3);
            tbp_DetectByPicture.Size = new Size(974, 558);
            tbp_DetectByPicture.TabIndex = 0;
            tbp_DetectByPicture.Text = "شناسایی با عکس";
            tbp_DetectByPicture.UseVisualStyleBackColor = true;
            // 
            // tbp_DetectRealtime
            // 
            tbp_DetectRealtime.Location = new Point(4, 24);
            tbp_DetectRealtime.Name = "tbp_DetectRealtime";
            tbp_DetectRealtime.Padding = new Padding(3);
            tbp_DetectRealtime.Size = new Size(974, 558);
            tbp_DetectRealtime.TabIndex = 1;
            tbp_DetectRealtime.Text = "شناسایی همزمان";
            tbp_DetectRealtime.UseVisualStyleBackColor = true;
            // 
            // tbp_RegisteredPlates
            // 
            tbp_RegisteredPlates.Location = new Point(4, 24);
            tbp_RegisteredPlates.Name = "tbp_RegisteredPlates";
            tbp_RegisteredPlates.Size = new Size(974, 558);
            tbp_RegisteredPlates.TabIndex = 2;
            tbp_RegisteredPlates.Text = "پلاک‌های ثبت شده";
            tbp_RegisteredPlates.UseVisualStyleBackColor = true;
            // 
            // tbp_RegisteredPersons
            // 
            tbp_RegisteredPersons.Location = new Point(4, 24);
            tbp_RegisteredPersons.Name = "tbp_RegisteredPersons";
            tbp_RegisteredPersons.Size = new Size(974, 558);
            tbp_RegisteredPersons.TabIndex = 3;
            tbp_RegisteredPersons.Text = "شهروندان ثبت شده";
            tbp_RegisteredPersons.UseVisualStyleBackColor = true;
            // 
            // formMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 610);
            Controls.Add(tab_MainTab);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formMain";
            Text = "پیلاک";
            tab_MainTab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tab_MainTab;
        private TabPage tbp_DetectByPicture;
        private TabPage tbp_DetectRealtime;
        private TabPage tbp_RegisteredPlates;
        private TabPage tbp_RegisteredPersons;
    }
}
