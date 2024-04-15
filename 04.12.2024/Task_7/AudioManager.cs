using NAudio.Wave;
using System;
using static System.Console;

namespace Task_7
{
    /// <summary>
    /// Класс AudioManager, который реализует интерфейс IAudioManager
    /// с использованием библиотеки NAudio для записи 
    /// и воспроизведения звука
    /// </summary>
    public class AudioManager : IAudioManager
    {
        private WaveInEvent waveSource;
        private WaveFileWriter waveFile;

        public void StartRecording()
        {
            waveSource = new WaveInEvent();
            waveSource.WaveFormat = new WaveFormat(44100, 1); // 44.1 kHz, mono
            waveSource.DataAvailable += WaveSource_DataAvailable;

            string fileName = $"recording_{DateTime.Now:yyyyMMddHHmmss}.wav";
            waveFile = new WaveFileWriter(fileName, waveSource.WaveFormat);

            waveSource.StartRecording();
            WriteLine("Recording started. Press Enter to stop recording...");
        }

        private void WaveSource_DataAvailable(object sender, WaveInEventArgs e)
        {
            waveFile.Write(e.Buffer, 0, e.BytesRecorded);
        }

        public void StopRecording()
        {
            if (waveSource != null)
            {
                waveSource.StopRecording();
                waveSource.Dispose();
            }

            if (waveFile != null)
            {
                waveFile.Dispose();
                WriteLine("Recording stopped.");
            }
        }

        public void Play(string audioFile)
        {
            using (var audioFileReader = new AudioFileReader(audioFile))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFileReader);
                outputDevice.Play();

                WriteLine("Playing audio...");
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    System.Threading.Thread.Sleep(100);
                }
            }
        }
    }
}
