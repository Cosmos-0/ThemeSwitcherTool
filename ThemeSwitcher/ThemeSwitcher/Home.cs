using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ThemeSwitcher
{
    public partial class Home : Form
    {

        int SystemRes;
        RegistryKey key;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        public Home()
        {
            InitializeComponent();
            this.TopMost = true;
            MessageBox.Show(SystemInformation.Network+"");

        }

        private void Home_Load(object sender, EventArgs e)
        {
            InitializeContextMenu();
            key = Registry.CurrentUser.OpenSubKey("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", true);
            SystemRes = (int)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "SystemUsesLightTheme", -1);
            themeSwitch.Checked = SystemRes.Equals(0);


        }

        private void themeSwitch_CheckedChanged(object sender, EventArgs e)
        {
            Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "SystemUsesLightTheme", SystemRes.Equals(0) ? 1 : 0);
            Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "AppsUseLightTheme", SystemRes.Equals(0) ? 1 : 0);
            SystemRes = SystemRes.Equals(0) ? 1 : 0;

        }

        private void Home_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();  // Hide the form
                notifyIcon.Visible = true; // Show the system tray icon
            }
        }



        private void notifyIcon_MouseDoubleClick(object sender, EventArgs e)
        {
            Show();  // Show the form
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = true; // Hide the system tray icon
        }

        private void InitializeContextMenu()
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem exitMenuItem = new ToolStripMenuItem("Exit");
            ToolStripMenuItem MinimizeMenuItem = new ToolStripMenuItem("Minimize");
            exitMenuItem.Click += (sender, e) => { Application.Exit(); };
            MinimizeMenuItem.Click += (sender, e) => { this.Hide(); };
            contextMenu.Items.Add(exitMenuItem);
            contextMenu.Items.Add(MinimizeMenuItem);
            notifyIcon.ContextMenuStrip = contextMenu;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void hideIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
