using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThemeSwitcher.CONTROL;

namespace ThemeSwitcher.STATICS
{
    sealed public class STATIC
    {
        const int WM_SETTINGCHANGE = 0x001A;
        const int HWND_BROADCAST = 0xFFFF;
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SendMessageTimeout(IntPtr hWnd, int Msg, IntPtr wParam, string lParam, uint fuFlags, uint uTimeout, IntPtr lpdwResult);


        private static string Theme =((int)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "SystemUsesLightTheme", -1)).Equals(0)? "dark" : "light";
        public static string theme
        {
            get { return Theme; }
            set
            {
                if (Theme != value)
                {
                    Theme = value;
                    ThemeChangeTrigger();

                }
            }
        }

        private static void ThemeChangeTrigger()
        {
            ChangeThemeMode(theme.Equals("dark"));
        }

        public static List<SwitchButton> switchBtns = new List<SwitchButton>();
        public  static async Task ChangeThemeMode(bool darkMode)
        {   
            await Task.Run(() =>
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", true))
                {
                    if (key != null)
                    {
                        key.SetValue("AppsUseLightTheme", darkMode ? 0 : 1);
                        key.SetValue("SystemUsesLightTheme", darkMode ? 0 : 1);
                        SendMessageTimeout((IntPtr)HWND_BROADCAST, WM_SETTINGCHANGE, IntPtr.Zero, "ImmersiveColorSet", 0, 1000, IntPtr.Zero); // Notify all windows about the theme change
                    }
                }
            });
        }



        public static void InitializeContextMenu(NotifyIcon notifyIcon, Form frm,Icon ico)
        {
            notifyIcon.Icon = ico;
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem exitMenuItem = new ToolStripMenuItem("Exit");
            ToolStripMenuItem MinimizeMenuItem = new ToolStripMenuItem("Minimize");
            exitMenuItem.Click += (sender, e) => { Application.Exit(); };
            MinimizeMenuItem.Click += (sender, e) => { frm.Hide(); };
            contextMenu.Items.Add(exitMenuItem);
            contextMenu.Items.Add(MinimizeMenuItem);
            notifyIcon.ContextMenuStrip = contextMenu;
            notifyIcon.DoubleClick += (args, e) => { frm.Show(); };
        }

        



    }
}
