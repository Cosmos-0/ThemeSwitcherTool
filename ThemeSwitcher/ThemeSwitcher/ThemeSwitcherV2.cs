using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThemeSwitcher.CONTROL;
using ThemeSwitcher.STATICS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ThemeSwitcher
{
    public partial class ThemeSwitcherV2 : Form
    {

        //For Form Draggability
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        //For Hotkeys
        public const int WM_HOTKEY = 0x0312;
        public const int HOTKEY_ID = 9000;  // Arbitrary unique ID to identify the hotkey
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        public ThemeSwitcherV2()
        {
            InitializeComponent();
            STATIC.MAIN_FRM = this;
            RegisterHotKey(this.Handle, HOTKEY_ID, 0, (uint)Keys.F9);
            this.FormClosing += (args, e) => { UnregisterHotKey(this.Handle, HOTKEY_ID); };
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = Region.FromHrgn(STATIC.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.hideBtn.Click += (args, e) => { this.Hide(); };
            STATIC.InitializeContextMenu(notifyIcon, this, Properties.Resources.notify);

            Task.Run(() =>
            {
                SwitchButton btnLight = new SwitchButton(Properties.Resources.Sun, "Light", "light");
                SwitchButton btnDark = new SwitchButton(Properties.Resources.Moon, "Dark", "dark");

                STATIC.switchBtns.Clear();
                STATIC.switchBtns.Add(btnLight);
                STATIC.switchBtns.Add(btnDark);

                btnLight.Width = Convert.ToInt16(tablelayout.Width * 0.50);
                btnDark.Width = Convert.ToInt16(tablelayout.Width * 0.50);
                btnLight.Height = tablelayout.Height;
                btnDark.Height = tablelayout.Height;

                tablelayout.Invoke(new Action(() =>
                {
                    tablelayout.Controls.Clear();
                    tablelayout.Controls.Add(btnLight);
                    tablelayout.Controls.Add(btnDark);
                }));
                UpdateFormColors();
            });
            





        }

        public void UpdateFormColors()
        {
            this.BackColor = STATIC.theme.Equals("dark") ? Color.FromArgb(41, 41, 41) : Color.White;
            ThemeLabel.ForeColor = !STATIC.theme.Equals("dark") ? Color.FromArgb(41, 41, 41) : Color.White;
            tablelayout.BackColor = STATIC.theme.Equals("dark") ? Color.FromArgb(30, 30, 30) : Color.Silver;
        }

        private void ThemeSwitcherV2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_HOTKEY && (int)m.WParam == HOTKEY_ID)
            {
                STATIC.theme = STATIC.theme.Equals("dark") ? "light" : "dark";
            }
        }
    }
}
