namespace ThemeSwitcher
{
    partial class ThemeSwitcherV2
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
            notifyIcon = new System.Windows.Forms.NotifyIcon(components);
            tablelayout = new System.Windows.Forms.TableLayoutPanel();
            hideBtn = new System.Windows.Forms.PictureBox();
            titleApp = new System.Windows.Forms.Label();
            ShortcutF9 = new System.Windows.Forms.Label();
            ThemeLabel = new System.Windows.Forms.Label();
            lbl_automaticTheme = new System.Windows.Forms.Label();
            AutomaticCheck = new ReaLTaiizor.Controls.CyberSwitch();
            lbl_DarkFrom = new System.Windows.Forms.Label();
            lbl__lightFrom = new System.Windows.Forms.Label();
            AutomaticTimePanel = new System.Windows.Forms.Panel();
            TimeDark = new System.Windows.Forms.DateTimePicker();
            TimeLight = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)hideBtn).BeginInit();
            AutomaticTimePanel.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIcon
            // 
            notifyIcon.Text = "notifyIcon";
            notifyIcon.Visible = true;
            // 
            // tablelayout
            // 
            tablelayout.BackColor = System.Drawing.Color.SkyBlue;
            tablelayout.ColumnCount = 2;
            tablelayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tablelayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tablelayout.Location = new System.Drawing.Point(128, 106);
            tablelayout.Name = "tablelayout";
            tablelayout.Padding = new System.Windows.Forms.Padding(5);
            tablelayout.RowCount = 1;
            tablelayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tablelayout.Size = new System.Drawing.Size(226, 54);
            tablelayout.TabIndex = 5;
            // 
            // hideBtn
            // 
            hideBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            hideBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            hideBtn.Image = Properties.Resources.close;
            hideBtn.Location = new System.Drawing.Point(445, 1);
            hideBtn.Name = "hideBtn";
            hideBtn.Size = new System.Drawing.Size(35, 33);
            hideBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            hideBtn.TabIndex = 7;
            hideBtn.TabStop = false;
            // 
            // titleApp
            // 
            titleApp.AutoSize = true;
            titleApp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            titleApp.Location = new System.Drawing.Point(3, 11);
            titleApp.Name = "titleApp";
            titleApp.Size = new System.Drawing.Size(140, 20);
            titleApp.TabIndex = 8;
            titleApp.Text = "ThemeSwitcher V2";
            // 
            // ShortcutF9
            // 
            ShortcutF9.Anchor = System.Windows.Forms.AnchorStyles.None;
            ShortcutF9.AutoSize = true;
            ShortcutF9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ShortcutF9.ForeColor = System.Drawing.Color.Gray;
            ShortcutF9.Location = new System.Drawing.Point(222, 84);
            ShortcutF9.Name = "ShortcutF9";
            ShortcutF9.Size = new System.Drawing.Size(38, 20);
            ShortcutF9.TabIndex = 11;
            ShortcutF9.Text = "(F9)";
            // 
            // ThemeLabel
            // 
            ThemeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            ThemeLabel.AutoSize = true;
            ThemeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ThemeLabel.ForeColor = System.Drawing.Color.Gray;
            ThemeLabel.Location = new System.Drawing.Point(203, 56);
            ThemeLabel.Name = "ThemeLabel";
            ThemeLabel.Size = new System.Drawing.Size(76, 28);
            ThemeLabel.TabIndex = 12;
            ThemeLabel.Text = "Theme";
            // 
            // lbl_automaticTheme
            // 
            lbl_automaticTheme.Anchor = System.Windows.Forms.AnchorStyles.None;
            lbl_automaticTheme.AutoSize = true;
            lbl_automaticTheme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_automaticTheme.ForeColor = System.Drawing.Color.Gray;
            lbl_automaticTheme.Location = new System.Drawing.Point(12, 186);
            lbl_automaticTheme.Name = "lbl_automaticTheme";
            lbl_automaticTheme.Size = new System.Drawing.Size(257, 28);
            lbl_automaticTheme.TabIndex = 13;
            lbl_automaticTheme.Text = "Automatic Theme Change";
            // 
            // AutomaticCheck
            // 
            AutomaticCheck.Alpha = 50;
            AutomaticCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            AutomaticCheck.BackColor = System.Drawing.Color.Transparent;
            AutomaticCheck.Background = true;
            AutomaticCheck.Background_WidthPen = 2F;
            AutomaticCheck.BackgroundPen = true;
            AutomaticCheck.Checked = false;
            AutomaticCheck.ColorBackground = System.Drawing.Color.Thistle;
            AutomaticCheck.ColorBackground_1 = System.Drawing.SystemColors.Control;
            AutomaticCheck.ColorBackground_2 = System.Drawing.SystemColors.ControlDark;
            AutomaticCheck.ColorBackground_Pen = System.Drawing.SystemColors.Control;
            AutomaticCheck.ColorBackground_Value_1 = System.Drawing.Color.FromArgb(28, 200, 238);
            AutomaticCheck.ColorBackground_Value_2 = System.Drawing.Color.FromArgb(100, 208, 232);
            AutomaticCheck.ColorLighting = System.Drawing.Color.FromArgb(29, 200, 238);
            AutomaticCheck.ColorPen_1 = System.Drawing.Color.FromArgb(37, 52, 68);
            AutomaticCheck.ColorPen_2 = System.Drawing.Color.FromArgb(41, 63, 86);
            AutomaticCheck.ColorValue = System.Drawing.Color.DodgerBlue;
            AutomaticCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            AutomaticCheck.CyberSwitchStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            AutomaticCheck.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            AutomaticCheck.ForeColor = System.Drawing.Color.FromArgb(245, 245, 245);
            AutomaticCheck.Lighting = false;
            AutomaticCheck.LinearGradient_Background = false;
            AutomaticCheck.LinearGradient_Value = false;
            AutomaticCheck.LinearGradientPen = false;
            AutomaticCheck.Location = new System.Drawing.Point(431, 186);
            AutomaticCheck.Name = "AutomaticCheck";
            AutomaticCheck.PenWidth = 10;
            AutomaticCheck.RGB = false;
            AutomaticCheck.Rounding = true;
            AutomaticCheck.RoundingInt = 90;
            AutomaticCheck.Size = new System.Drawing.Size(39, 28);
            AutomaticCheck.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            AutomaticCheck.TabIndex = 14;
            AutomaticCheck.Tag = "Cyber";
            AutomaticCheck.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            AutomaticCheck.Timer_RGB = 300;
            AutomaticCheck.CheckedChanged += AutomaticCheck_CheckedChanged;
            // 
            // lbl_DarkFrom
            // 
            lbl_DarkFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            lbl_DarkFrom.AutoSize = true;
            lbl_DarkFrom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_DarkFrom.ForeColor = System.Drawing.Color.Gray;
            lbl_DarkFrom.Location = new System.Drawing.Point(253, 8);
            lbl_DarkFrom.Name = "lbl_DarkFrom";
            lbl_DarkFrom.Size = new System.Drawing.Size(89, 20);
            lbl_DarkFrom.TabIndex = 22;
            lbl_DarkFrom.Text = "Dark from :";
            // 
            // lbl__lightFrom
            // 
            lbl__lightFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            lbl__lightFrom.AutoSize = true;
            lbl__lightFrom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl__lightFrom.ForeColor = System.Drawing.Color.Gray;
            lbl__lightFrom.Location = new System.Drawing.Point(116, 8);
            lbl__lightFrom.Name = "lbl__lightFrom";
            lbl__lightFrom.Size = new System.Drawing.Size(92, 20);
            lbl__lightFrom.TabIndex = 20;
            lbl__lightFrom.Text = "Light from :";
            // 
            // AutomaticTimePanel
            // 
            AutomaticTimePanel.BackColor = System.Drawing.Color.Transparent;
            AutomaticTimePanel.Controls.Add(TimeDark);
            AutomaticTimePanel.Controls.Add(TimeLight);
            AutomaticTimePanel.Controls.Add(lbl__lightFrom);
            AutomaticTimePanel.Controls.Add(lbl_DarkFrom);
            AutomaticTimePanel.Location = new System.Drawing.Point(12, 219);
            AutomaticTimePanel.Name = "AutomaticTimePanel";
            AutomaticTimePanel.Size = new System.Drawing.Size(458, 69);
            AutomaticTimePanel.TabIndex = 23;
            // 
            // TimeDark
            // 
            TimeDark.Anchor = System.Windows.Forms.AnchorStyles.None;
            TimeDark.CustomFormat = "HH:mm";
            TimeDark.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            TimeDark.Location = new System.Drawing.Point(253, 31);
            TimeDark.Name = "TimeDark";
            TimeDark.Size = new System.Drawing.Size(89, 27);
            TimeDark.TabIndex = 25;
            TimeDark.Value = new System.DateTime(2023, 11, 3, 2, 22, 43, 0);
            TimeDark.ValueChanged += TimeLight_ValueChanged;
            // 
            // TimeLight
            // 
            TimeLight.Anchor = System.Windows.Forms.AnchorStyles.None;
            TimeLight.CustomFormat = "HH:mm";
            TimeLight.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            TimeLight.Location = new System.Drawing.Point(116, 31);
            TimeLight.Name = "TimeLight";
            TimeLight.Size = new System.Drawing.Size(92, 27);
            TimeLight.TabIndex = 24;
            TimeLight.Value = new System.DateTime(2023, 11, 3, 2, 22, 49, 0);
            TimeLight.ValueChanged += TimeLight_ValueChanged;
            // 
            // ThemeSwitcherV2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(482, 434);
            Controls.Add(AutomaticTimePanel);
            Controls.Add(AutomaticCheck);
            Controls.Add(lbl_automaticTheme);
            Controls.Add(ThemeLabel);
            Controls.Add(ShortcutF9);
            Controls.Add(titleApp);
            Controls.Add(hideBtn);
            Controls.Add(tablelayout);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "ThemeSwitcherV2";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ThemeSwitcherV2";
            TransparencyKey = System.Drawing.Color.Fuchsia;
            MouseDown += ThemeSwitcherV2_MouseDown;
            ((System.ComponentModel.ISupportInitialize)hideBtn).EndInit();
            AutomaticTimePanel.ResumeLayout(false);
            AutomaticTimePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.TableLayoutPanel tablelayout;
        private System.Windows.Forms.PictureBox hideBtn;
        private System.Windows.Forms.Label titleApp;
        private System.Windows.Forms.Label ShortcutF9;
        private System.Windows.Forms.Label ThemeLabel;
        private System.Windows.Forms.Label lbl_automaticTheme;
        private ReaLTaiizor.Controls.CyberSwitch AutomaticCheck;
        private System.Windows.Forms.Label lbl_DarkFrom;
        private System.Windows.Forms.Label lbl__lightFrom;
        private System.Windows.Forms.Panel AutomaticTimePanel;
        private System.Windows.Forms.DateTimePicker TimeLight;
        private System.Windows.Forms.DateTimePicker TimeDark;

        #endregion

        //private ReaLTaiizor.Forms.AirForm airForm1;
    }
}