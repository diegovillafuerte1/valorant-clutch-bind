using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public struct ApplicationThemeSettings
    {
        public Color ButtonMenu_BackColor;
        public Color ButtonMenu_ForeColor;

        public Color ButtonSubMenu_BackColor;
        public Color ButtonSubMenu_ForeColor;

        public Color PanelWindow_BackColor;
        public Color PanelSubMenu_BackColor; //Generally not seen?

        public FlatStyle ButtonFlatStyle;
        public int ButtonBorderSize;
    }

    public enum Theme
    {
        Valorant,
        Green
    }

    class ThemeProvider
    {
        private static ApplicationThemeSettings ValorantThemeSettings = new ApplicationThemeSettings
        {
            ButtonMenu_BackColor = Color.FromArgb(0, 0, 0),
            ButtonMenu_ForeColor = Color.DarkRed,
            ButtonSubMenu_BackColor = Color.FromArgb(32, 32, 32),
            ButtonSubMenu_ForeColor = Color.Silver,

            PanelWindow_BackColor = Color.FromArgb(64, 0, 0),
            PanelSubMenu_BackColor = Color.Black,

            ButtonFlatStyle = FlatStyle.Flat,
            ButtonBorderSize = 0
        };

        private static ApplicationThemeSettings GreenThemeSettings = new ApplicationThemeSettings
        {
            ButtonMenu_BackColor = Color.FromArgb(0, 0, 0),
            ButtonMenu_ForeColor = Color.DarkGreen,
            ButtonSubMenu_BackColor = Color.FromArgb(32, 32, 32),
            ButtonSubMenu_ForeColor = Color.Silver,

            PanelWindow_BackColor = Color.FromArgb(0, 64, 0),
            PanelSubMenu_BackColor = Color.Black,

            ButtonFlatStyle = FlatStyle.Flat,
            ButtonBorderSize = 0
        };

        public static ApplicationThemeSettings GetThemeSettings()
        {
            switch (SettingsProvider.SelectedTheme)
            {
                case Theme.Valorant:
                    return ValorantThemeSettings;
                case Theme.Green:
                    return GreenThemeSettings;
            }
            throw new NotImplementedException($"Theme {SettingsProvider.SelectedTheme} not recognized");
        }

    }


}