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
            hideIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hideIcon).BeginInit();
            SuspendLayout();
            // 
            // themeSwitch
            // 
            themeSwitch.Anchor = System.Windows.Forms.AnchorStyles.None;
            themeSwitch.AutoSize = true;
            themeSwitch.BaseColor = System.Drawing.Color.White;
            themeSwitch.BaseOffColor = System.Drawing.Color.FromArgb(220, 223, 230);
            themeSwitch.BaseOnColor = System.Drawing.Color.FromArgb(64, 158, 255);
            themeSwitch.Location = new System.Drawing.Point(69, 51);
            themeSwitch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            themeSwitch.Name = "themeSwitch";
            themeSwitch.Size = new System.Drawing.Size(40, 20);
            themeSwitch.TabIndex = 1;
            themeSwitch.Text = "&ThemeSwitcher";
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
            pictureBox.Location = new System.Drawing.Point(24, 47);
            pictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new System.Drawing.Size(50, 29);
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            pictureBox.MouseDown += pictureBox_MouseDown;
            // 
            // hideIcon
            // 
            hideIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            hideIcon.Image = (System.Drawing.Image)resources.GetObject("hideIcon.Image");
            hideIcon.InitialImage = null;
            hideIcon.Location = new System.Drawing.Point(115, 47);
            hideIcon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            hideIcon.Name = "hideIcon";
            hideIcon.Size = new System.Drawing.Size(38, 29);
            hideIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            hideIcon.TabIndex = 3;
            hideIcon.TabStop = false;
            hideIcon.Click += hideIcon_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Green;
            ClientSize = new System.Drawing.Size(183, 113);
            Controls.Add(hideIcon);
            Controls.Add(themeSwitch);
            Controls.Add(pictureBox);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(1561, 971);
            MinimizeBox = false;
            Name = "Home";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Theme switcher";
            TransparencyKey = System.Drawing.Color.Green;
            Load += Home_Load;
            Shown += hideIcon_Click;
            Resize += Home_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)hideIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private ReaLTaiizor.Controls.HopeSwitch themeSwitch;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.PictureBox hideIcon;

        #endregion
        //private ReaLTaiizor.Controls.ParrotFormHandle parrotFormHandle1;
    }
}

