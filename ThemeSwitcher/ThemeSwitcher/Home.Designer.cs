namespace ThemeSwitcher
{
    partial class Home
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            themeSwitch = new ReaLTaiizor.Controls.HopeSwitch();
            notifyIcon = new System.Windows.Forms.NotifyIcon(components);
            pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // themeSwitch
            // 
            themeSwitch.Anchor = System.Windows.Forms.AnchorStyles.None;
            themeSwitch.AutoSize = true;
            themeSwitch.BaseColor = System.Drawing.Color.White;
            themeSwitch.BaseOffColor = System.Drawing.Color.FromArgb(220, 223, 230);
            themeSwitch.BaseOnColor = System.Drawing.Color.FromArgb(64, 158, 255);
            themeSwitch.Location = new System.Drawing.Point(11, 12);
            themeSwitch.Name = "themeSwitch";
            themeSwitch.Size = new System.Drawing.Size(40, 20);
            themeSwitch.TabIndex = 1;
            themeSwitch.Text = "ThemeSwitcher";
            themeSwitch.UseVisualStyleBackColor = true;
            themeSwitch.CheckedChanged += themeSwitch_CheckedChanged;
            // 
            // notifyIcon
            // 
            notifyIcon.Icon = (System.Drawing.Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "Theme switcher ";
            notifyIcon.Visible = true;
            notifyIcon.DoubleClick += notifyIcon_MouseDoubleClick;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            pictureBox.Image = (System.Drawing.Image)resources.GetObject("pictureBox.Image");
            pictureBox.InitialImage = null;
            pictureBox.Location = new System.Drawing.Point(11, 1);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new System.Drawing.Size(15, 11);
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            pictureBox.MouseDown += pictureBox_MouseDown;
            // 
            // Home
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Green;
            ClientSize = new System.Drawing.Size(63, 44);
            Controls.Add(pictureBox);
            Controls.Add(themeSwitch);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(1366, 728);
            MinimizeBox = false;
            Name = "Home";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Theme switcher";
            TransparencyKey = System.Drawing.Color.Green;
            Load += Home_Load;
            Resize += Home_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private ReaLTaiizor.Controls.HopeSwitch themeSwitch;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.PictureBox pictureBox;

        #endregion
        //private ReaLTaiizor.Controls.ParrotFormHandle parrotFormHandle1;
    }
}

