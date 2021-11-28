using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.CustomControls
{
    interface IThemedControl
    {
        void UpdateTheme(ApplicationThemeSettings themeSettings);
    }
}
