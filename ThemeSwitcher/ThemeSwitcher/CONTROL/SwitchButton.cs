using ReaLTaiizor.Child.Material;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThemeSwitcher.Properties;
using ThemeSwitcher.STATICS;

namespace ThemeSwitcher.CONTROL
{
    public partial class SwitchButton : UserControl
    {
        string accessibleName;
        public SwitchButton(Image icon, string txt, string accessibleName)
        {
            InitializeComponent();
            this.icon.Image = icon;
            this.txt.Text = txt;
            this.accessibleName = accessibleName;
            RefreshComponent(this);

        }

        private void switchBtnClick(object sender, EventArgs e)
        {
            STATIC.theme = accessibleName;
            RefreshState();
            MainParentThemeRefresh();
        }


        private void MainParentThemeRefresh()
        {
            ThemeSwitcherV2 parent = (ThemeSwitcherV2)this.Parent.Parent;
            MessageBox.Show(parent.Name);
        }

        void RefreshComponent(SwitchButton btn)
        {
            btn.BackColor = Color.Silver;
            btn.txt.ForeColor = Color.Black;
            if (btn.accessibleName.Equals(STATIC.theme))
            {
                btn.BackColor = Color.White;
                btn.txt.ForeColor = Color.FromName("AppWorkspace");
            }
        }

         void RefreshState()
        {
            foreach (SwitchButton item in STATIC.switchBtns)
                RefreshComponent(item);
        }


    }
}
