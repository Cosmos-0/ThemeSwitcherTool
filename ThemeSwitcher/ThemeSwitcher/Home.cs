using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public const int WM_HOTKEY = 0x0312;
        public const int HOTKEY_ID = 9000;  // Arbitrary unique ID to identify the hotkey
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam,  int lParam);

        public Home()
        {
            InitializeComponent();
            this.TopMost = true;
<<<<<<< HEAD
            try
            {
                string appName = "ThemeSwitcher";
                string appPath = Application.ExecutablePath;

                RegistryKey startupKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

                if (startupKey.GetValue(appName) == null) // Check if the app is already added to startup
                {
                    startupKey.SetValue(appName, appPath); // Add the app to startup
                }

                startupKey.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
=======
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
>>>>>>> 14da5c76a0f6d6a934023f675ff1a503f5114005
        }

        

        private void Home_Load(object sender, EventArgs e)
        {
            InitializeContextMenu();
            key = Registry.CurrentUser.OpenSubKey("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", true);
            SystemRes = (int)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "SystemUsesLightTheme", -1);
            themeSwitch.Checked = SystemRes.Equals(0);
            RegisterHotKey(this.Handle, HOTKEY_ID, 0, (uint)Keys.F9);  // Register F9 as global hotkey
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, HOTKEY_ID);  // Unregister the global hotkey when the form is closing
        }

        private void ToggleTheme()
        {
            //MessageBox.Show("Test");
            themeSwitch.Checked = !themeSwitch.Checked;
            //themeSwitch_CheckedChanged(null, null);  // Trigger the CheckedChanged event
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_HOTKEY && (int)m.WParam == HOTKEY_ID)
            {
                ToggleTheme();
            }
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
