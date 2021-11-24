using System;
using System.Collections.Generic;
using System.Text;
using NAudio.Wave;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public static class AudioPlayer
    {
        private static WaveOutEvent _waveOutEvent;
        private static Mp3FileReader _mp3Reader;
        private static bool _playbackStopped = true;
        private static string muteMP3Path = "AudioAssets/quiet-viper-1.mp3";
        private static string unmuteMP3Path = "AudioAssets/back-viper-1.mp3";

        static AudioPlayer()
        {
        }
        public async static Task PlayMuteSound()
        {
            await PlaySound(muteMP3Path);
        }

        public async static Task PlayUnmuteSound()
        {
            await PlaySound(unmuteMP3Path);
        }

        public async static Task PlaySound(string audioFilePath)
        {
            await StopAudioIfPlaying();
            _mp3Reader = new Mp3FileReader(audioFilePath);
            _waveOutEvent = new WaveOutEvent();
            _waveOutEvent.PlaybackStopped += OnPlaybackStopped;
            _waveOutEvent.Init(_mp3Reader);
            _waveOutEvent.Play();
            _playbackStopped = false;
        }

        private static bool IsAudioPlaying()
        {
            return !_playbackStopped;
        }

        private async static Task StopAudioIfPlaying()
        {
            if (IsAudioPlaying())
            {
                _waveOutEvent.Stop();
            }
            while (IsAudioPlaying()) { await Task.Delay(100); }
        }

        public static void OnPlaybackStopped(object sender, StoppedEventArgs eventArgs)
        {
            _mp3Reader?.Dispose();
            _mp3Reader = null;
            _waveOutEvent?.Dispose();
            _waveOutEvent = null;
            _playbackStopped = true;
        }
    }
}
