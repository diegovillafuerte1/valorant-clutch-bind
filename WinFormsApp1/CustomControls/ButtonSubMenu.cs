using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WinFormsApp1.CustomControls
{
    class ButtonSubMenu : Button, IThemedControl
    {
        protected virtual Color CustomBackColor { get; set; } = Color.FromArgb(32, 32, 32);
        protected virtual Color CustomTextColor { get; set; } = Color.Silver;
        public ButtonSubMenu()
        {
            UpdateTheme(ThemeProvider.GetThemeSettings());
        }

        public void UpdateTheme(ApplicationThemeSettings themeSettings)
        {
            this.BackColor = themeSettings.ButtonSubMenu_BackColor;
            this.ForeColor = themeSettings.ButtonSubMenu_ForeColor;

            //Flat button appearance
            this.FlatStyle = themeSettings.ButtonFlatStyle;
            this.FlatAppearance.BorderSize = themeSettings.ButtonBorderSize;
        }
    }
}
