using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyrion.Models
{
    public class Tune
    {
        private IWavePlayer waveOut { get; set; }
        private Mp3FileReader mp3FileReader { get; set; }
        public string artist { get; set; }
        public string albumArtist { get; set; }
        public string album { get; set; }
        public string title { get; set; }
        public string trackNumber { get; set; }
        public string path { get; set; }
        public Stream stream { get; set; }

        public void PlayStream()
        {
            this.waveOut = new WaveOut();
            this.mp3FileReader = new Mp3FileReader(this.stream);
            this.waveOut.Init(mp3FileReader);
            this.waveOut.Play();
            this.waveOut.PlaybackStopped += StopSong;
        }
        public void Play()
        {
            this.waveOut = new WaveOut();
            this.mp3FileReader = new Mp3FileReader(this.path);
            this.waveOut.Init(mp3FileReader);
            this.waveOut.Play();
            this.waveOut.PlaybackStopped += StopSong;
        }
        private void StopSong(object sender, StoppedEventArgs e)
        {
            this.Stop();
        }
        public void Stop()
        {
            this.waveOut.Dispose();
            this.mp3FileReader.Dispose();
        }
    }
}
