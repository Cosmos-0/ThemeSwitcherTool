using System.Drawing;

namespace ThemeSwitcher.CONTROL
{
    partial class SwitchButton
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            txt = new System.Windows.Forms.Label();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            icon = new System.Windows.Forms.PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icon).BeginInit();
            SuspendLayout();
            // 
            // txt
            // 
            txt.BackColor = Color.Transparent;
            txt.Dock = System.Windows.Forms.DockStyle.Fill;
            txt.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txt.ForeColor = Color.Black;
            txt.Location = new Point(111, 0);
            txt.Name = "txt";
            txt.Size = new Size(174, 73);
            txt.TabIndex = 1;
            txt.Text = "Light";
            txt.TextAlign = ContentAlignment.MiddleCenter;
            txt.Click += switchBtnClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            tableLayoutPanel1.Controls.Add(txt, 1, 0);
            tableLayoutPanel1.Controls.Add(icon, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(288, 73);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // icon
            // 
            icon.BackColor = Color.Transparent;
            icon.Dock = System.Windows.Forms.DockStyle.Fill;
            icon.Image = Properties.Resources.Sun;
            icon.Location = new Point(3, 3);
            icon.Name = "icon";
            icon.Size = new Size(102, 67);
            icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            icon.TabIndex = 2;
            icon.TabStop = false;
            icon.Click += switchBtnClick;
            // 
            // SwitchButton
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(tableLayoutPanel1);
            Cursor = System.Windows.Forms.Cursors.Hand;
            Margin = new System.Windows.Forms.Padding(0);
            Name = "SwitchButton";
            Size = new Size(288, 73);
            Click += switchBtnClick;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icon).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox icon;
    }
}
