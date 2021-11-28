using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WinFormsApp1.CustomControls
{
    class PanelWindow : Panel, IThemedControl
    {
        public PanelWindow()
        {
            UpdateTheme(ThemeProvider.GetThemeSettings());
        }

        public void UpdateTheme(ApplicationThemeSettings themeSettings)
        {
            this.BackColor = themeSettings.PanelWindow_BackColor;
        }
    }
}
