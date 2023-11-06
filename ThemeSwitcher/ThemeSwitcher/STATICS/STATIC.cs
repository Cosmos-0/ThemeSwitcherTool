﻿using Microsoft.Win32;
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
        public static Color LightforeColor = Color.FromArgb(41, 41, 41);
        public static Color LightforeColor2 = Color.Gray;
        public static Color DarkforeColor = Color.White;
        public static Color LightbackColor = Color.White;
        public static Color DarkbackColor = Color.FromArgb(41, 41, 41);
        public static Color DarkbackColor2 = Color.FromArgb(79, 79, 79);

        public static ThemeSwitcherV2 MAIN_FRM;

        const int WM_SETTINGCHANGE = 0x001A;
        const int HWND_BROADCAST = 0xFFFF;
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SendMessageTimeout(IntPtr hWnd, int Msg, IntPtr wParam, string lParam, uint fuFlags, uint uTimeout, IntPtr lpdwResult);


        //For Form Rounded Border 
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );



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
            MAIN_FRM.UpdateFormColors();
            switchBtns[0].RefreshState();
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