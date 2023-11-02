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
            ThemeLabel = new System.Windows.Forms.Label();
            tablelayout = new System.Windows.Forms.TableLayoutPanel();
            hideBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)hideBtn).BeginInit();
            SuspendLayout();
            // 
            // notifyIcon
            // 
            notifyIcon.Text = "notifyIcon";
            notifyIcon.Visible = true;
            // 
            // ThemeLabel
            // 
            ThemeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            ThemeLabel.AutoSize = true;
            ThemeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ThemeLabel.ForeColor = System.Drawing.Color.Gray;
            ThemeLabel.Location = new System.Drawing.Point(202, 56);
            ThemeLabel.Name = "ThemeLabel";
            ThemeLabel.Size = new System.Drawing.Size(76, 28);
            ThemeLabel.TabIndex = 6;
            ThemeLabel.Text = "Theme";
            // 
            // tablelayout
            // 
            tablelayout.BackColor = System.Drawing.Color.Silver;
            tablelayout.ColumnCount = 2;
            tablelayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tablelayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tablelayout.Location = new System.Drawing.Point(128, 87);
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
            // ThemeSwitcherV2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(482, 434);
            Controls.Add(hideBtn);
            Controls.Add(ThemeLabel);
            Controls.Add(tablelayout);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "ThemeSwitcherV2";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ThemeSwitcherV2";
            TransparencyKey = System.Drawing.Color.Fuchsia;
            MouseDown += ThemeSwitcherV2_MouseDown;
            ((System.ComponentModel.ISupportInitialize)hideBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label ThemeLabel;
        private System.Windows.Forms.TableLayoutPanel tablelayout;
        private System.Windows.Forms.PictureBox hideBtn;

        #endregion

        //private ReaLTaiizor.Forms.AirForm airForm1;
    }
}