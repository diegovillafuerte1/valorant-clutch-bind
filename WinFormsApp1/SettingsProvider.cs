using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    public static class SettingsProvider
    {
        public static Theme SelectedTheme { get; set; } = Theme.Valorant;
        public static Agents SelectedAgent { get; set; } = Agents.Viper;
        public static string NotificationVoiceSelection { get; set; } //TODO:  User can select an agent voice to be the notification sound of when they mute/unmute
        public static List<string> TargetAudioSessions { get; set; } //TODO:  User can see and select one or many audio sessions to be the target of mute.
    }
}
