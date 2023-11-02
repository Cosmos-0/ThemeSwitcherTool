using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ThemeSwitcher.STATICS;
using Microsoft.Win32;

namespace ThemeSwitcher
{
    public partial class Home : Form
    {

        //RegistryKey key;
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
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public Home()
        {
            InitializeComponent();
            themeSwitch.Checked = STATIC.theme.Equals("dark");
            this.TopMost = true;
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

            this.FormClosing += new FormClosingEventHandler(this.Home_FormClosing);

        }


        private void Home_Load(object sender, EventArgs e)
        {
            //STATIC.InitializeContextMenu(notifyIcon,this);

            RegisterHotKey(this.Handle, HOTKEY_ID, 0, (uint)Keys.F9);  // Register F9 as global hotkey

        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, HOTKEY_ID);  // Unregister the global hotkey when the form is closing
        }

        private void ToggleTheme()
        {
            themeSwitch.Checked = !themeSwitch.Checked;
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
            STATIC.ChangeThemeMode(STATIC.theme.Equals("dark"));
            STATIC.theme = STATIC.theme.Equals("dark") ? "light" : "dark";
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
