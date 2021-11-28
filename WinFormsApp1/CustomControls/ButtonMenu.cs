using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WinFormsApp1.CustomControls
{
    class ButtonMenu : Button, IThemedControl
    {
        //Class should contain intialization based on theme (currently always red/black theme)
        protected virtual Color CustomBackColor { get; set; } = Color.FromArgb(0, 0, 0);
        protected virtual Color CustomTextColor { get; set; } = Color.DarkRed;
        public ButtonMenu()
        {
            UpdateTheme(ThemeProvider.GetThemeSettings());
        }

        public void UpdateTheme(ApplicationThemeSettings themeSettings)
        {
            this.BackColor = themeSettings.ButtonMenu_BackColor;
            this.ForeColor = themeSettings.ButtonMenu_ForeColor;

            //Flat button appearance
            this.FlatStyle = themeSettings.ButtonFlatStyle;
            this.FlatAppearance.BorderSize = themeSettings.ButtonBorderSize;

            foreach (var control in this.Controls)
            {
                if (control is IThemedControl themedControl)
                {
                    themedControl.UpdateTheme(ThemeProvider.GetThemeSettings());
                }
            }
        }
    }
}
