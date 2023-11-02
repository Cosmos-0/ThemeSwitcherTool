using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThemeSwitcher.CONTROL;

namespace ThemeSwitcher.STATICS
{
    public class STATIC
    {
        public static int SystemRes = (int)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "SystemUsesLightTheme", -1);
        public static string theme = SystemRes.Equals(0)?"dark":"light";

        public static List<SwitchButton> switchBtns = new List<SwitchButton>();
    }
}
