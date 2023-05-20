using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Music
    {
        private String tittle { get; set; }
        private Artist artist { get; set; }
        private int duration { get; set; }
        private String gender { get; set; }

        public Music(Artist artist, String tittle, String gender, int duration)
        {
            this.artist = artist;
            this.tittle = tittle;
            this.gender = gender;
            this.duration = duration;
        }

        public void Play() { }

        public void Stop() { }

        public void Pause() { }

    }
}
