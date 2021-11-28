using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WinFormsApp1.CustomControls
{
    class PanelSubMenu : Panel, IThemedControl
    {
        public PanelSubMenu()
        {
            UpdateTheme(ThemeProvider.GetThemeSettings());
        }

        public void UpdateTheme(ApplicationThemeSettings themeSettings)
        {
            this.BackColor = themeSettings.PanelSubMenu_BackColor;
        }
    }
}
