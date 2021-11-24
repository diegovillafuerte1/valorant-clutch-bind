using System;
using System.Collections.Generic;
using System.Text;
using NAudio.Wave;

namespace WinFormsApp1
{
    class AudioPlayer
    {
        public static void PlayMuteSound()
        {
            var reader = new Mp3FileReader("AudioAssets/quiet-viper-1.mp3");
            var waveOut = new WaveOutEvent();
            
                waveOut.Init(reader);
                waveOut.Play();
           
        }

        public static void PlayUnmuteSound()
        {
            var reader = new Mp3FileReader("AudioAssets/back-viper-1.mp3");
            var waveOut = new WaveOutEvent();

                waveOut.Init(reader);
                waveOut.Play();

        }
    }
}
