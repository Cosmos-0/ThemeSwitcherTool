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

        string LightDark, lightTime, darkTime;
        System.Windows.Forms.Timer AutomaticThemeTimer = new System.Windows.Forms.Timer();


        public bool AutomaticTheme;
        public ThemeSwitcherV2()
        {
            InitializeComponent();
            this.TopMost = true;
            STATIC.MAIN_FRM = this;
            RegisterHotKey(this.Handle, HOTKEY_ID, 0, (uint)Keys.F9);

            this.FormClosing += (args, e) => { UnregisterHotKey(this.Handle, HOTKEY_ID); };
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = Region.FromHrgn(STATIC.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.hideBtn.Click += (args, e) => { this.Hide(); };

            Registry.CurrentUser.CreateSubKey("Software\\ThemeSwitcher");
            LightDark = (string)Registry.GetValue("HKEY_CURRENT_USER\\Software\\ThemeSwitcher", "LightDark", "0");

            ConfigTimer();
            ExploreRegistryValues();
            TimeSetting();
            ConfigSwitchButtons();
            STATIC.InitializeContextMenu(notifyIcon, this, Properties.Resources.notify);

            AutomaticTimePanel.Enabled = AutomaticCheck.Checked;
            AutomaticTheme = Convert.ToBoolean(Registry.GetValue("HKEY_CURRENT_USER\\Software\\ThemeSwitcher", "AutomaticTheme", false).ToString().ToLower());
            AutomaticCheck.Checked = AutomaticTheme;
            TriggerTimer();

        }

        void TriggerTimer()
        {
            if (AutomaticTheme)
                AutomaticThemeTimer.Start();
            else AutomaticThemeTimer.Stop();
        }

        async Task ConfigTimer()
        {
            await Task.Run(() =>
            {
                AutomaticThemeTimer.Interval = 5000;
                AutomaticThemeTimer.Tick += (args, e) =>
                {
                    /*STATIC.theme = DateTime.Now >= DateTime.Today
                    .AddHours(
                        Convert.ToInt16(lightTime.Substring(0, lightTime.IndexOf(":"))))
                    .AddMinutes(
                        Convert.ToInt16(lightTime.Substring(lightTime.IndexOf(":") + 1)))
                    &&
                    DateTime.Now < DateTime
                    .Today
                    .AddHours(
                        Convert.ToInt16(lightTime.Substring(0, darkTime.IndexOf(":"))))
                    .AddMinutes(
                        Convert.ToInt16(darkTime.Substring(darkTime.IndexOf(":") + 1)))
                    ? "light" : "dark";*/
                    ExploreRegistryValues();
                    DateTime currentTime = DateTime.Now;
                    DateTime timeLight = DateTime.ParseExact(lightTime.Trim(), "HH:mm", null);
                    DateTime timeDark = DateTime.ParseExact(darkTime.Trim(), "HH:mm", null);
                    //MessageBox.Show($"current Time :{currentTime}\ntimeLight:{timeLight}\ntimeDark:{timeDark}");
                    MessageBox.Show($"current Time :{currentTime}\ntimeLight:{timeLight}\ntimeDark:{timeDark}\nresult:{currentTime >= timeLight && currentTime <= timeDark}");
                    STATIC.theme = currentTime >= timeLight && currentTime <= timeDark ? "light" : "dark";


                };
            });
        }

        private async Task ConfigSwitchButtons()
        {
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
        private void ExploreRegistryValues()
        {
            lightTime = !LightDark.Equals("0") ? LightDark.Substring(0, LightDark.IndexOf("&")) : lightTime = "07:00";
            darkTime = !LightDark.Equals("0") ? LightDark.Substring(LightDark.IndexOf("&") + 1) : darkTime = "18:00"; ;

        }
        private async Task TimeSetting()
        {
            await Task.Run(() =>
            {
                TimeDark.Invoke(new Action(() =>
                {
                    TimeDark.Format = DateTimePickerFormat.Custom;
                    TimeDark.CustomFormat = "HH:mm";
                    TimeDark.ShowUpDown = true;
                    TimeDark.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Convert.ToInt16(darkTime.Substring(0, darkTime.IndexOf(":"))), Convert.ToInt16(darkTime.Substring(darkTime.IndexOf(":") + 1)), 00);
                }));
                TimeLight.Invoke(new Action(() =>
                {
                    TimeLight.Format = DateTimePickerFormat.Custom;
                    TimeLight.CustomFormat = "HH:mm";
                    TimeLight.ShowUpDown = true;
                    TimeLight.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Convert.ToInt16(lightTime.Substring(0, lightTime.IndexOf(":"))), Convert.ToInt16(lightTime.Substring(lightTime.IndexOf(":") + 1)), 00);
                }));

            });
        }
        public void UpdateFormColors()
        {
            this.BackColor = STATIC.theme.Equals("dark") ? STATIC.DarkbackColor : STATIC.LightbackColor;
            ThemeLabel.ForeColor = STATIC.theme.Equals("dark") ? STATIC.DarkforeColor : STATIC.LightforeColor2;
            tablelayout.BackColor = STATIC.theme.Equals("dark") ? STATIC.DarkbackColor2 : Color.Silver;
            titleApp.ForeColor = STATIC.theme.Equals("dark") ? STATIC.DarkforeColor : STATIC.LightforeColor2;
            ShortcutF9.ForeColor = STATIC.theme.Equals("dark") ? STATIC.DarkforeColor : STATIC.LightforeColor2;
            lbl_automaticTheme.ForeColor = STATIC.theme.Equals("dark") ? STATIC.DarkforeColor : STATIC.LightforeColor2;
            lbl__lightFrom.ForeColor = STATIC.theme.Equals("dark") ? STATIC.DarkforeColor : STATIC.LightforeColor2;
            lbl_DarkFrom.ForeColor = STATIC.theme.Equals("dark") ? STATIC.DarkforeColor : STATIC.LightforeColor2;

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

        private void AutomaticCheck_CheckedChanged()
        {
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\ThemeSwitcher", "AutomaticTheme", AutomaticCheck.Checked);
            AutomaticTheme = AutomaticCheck.Checked;
            AutomaticTimePanel.Enabled = AutomaticCheck.Checked;
            TriggerTimer();
        }

        private void TimeLight_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"{TimeLight.Value.ToString("HH:mm")} & {TimeDark.Value.ToString("HH:mm")}");
            if (TimeDark.Value >= TimeLight.Value)
                Registry.SetValue("HKEY_CURRENT_USER\\Software\\ThemeSwitcher", "LightDark",
                    $"{TimeLight.Value.ToString("HH:mm")} & {TimeDark.Value.ToString("HH:mm")}");
            else MessageBox.Show("Time For Dark Mode Must Be Greater Than Time For Light Mode");



        }


    }
}
