using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    class Song
    {
        private string artistName;
        private string songName;
        private int minutes;
        private int seconds;
        public TimeSpan total;

       public Song(string aName, string sName, int min , int sec)
        {
            this.ArtistName = aName;
            this.SongName = sName;
            this.Minutes = min;
            this.Seconds = sec;
            total = new TimeSpan(0, min, sec);
        }




        public string ArtistName
        {
            get
            {
                return this.artistName;
            }
            private set
            {
                if (value.Length < 3 || value.Length > 20) throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
                this.artistName = value;
            }
        }

        public string SongName
        {
            get
            {
                return this.songName;
            }
            private set
            {
                if (value.Length < 3 || value.Length > 30) throw new ArgumentException("Song name should be between 3 and 30 symbols.");
                this.songName = value;
            }
        }

        public int Minutes
        {
            get
            {
                return this.minutes;
            }
            set
            {
                if (value < 0 || value > 14) throw new ArgumentException("Song minutes should be between 0 and 14.");
                this.minutes = value;
            }
        }

        public int Seconds
        {
            get
            {
                return this.seconds;
            }
            set
            {
                if (value < 0 || value > 59) throw new ArgumentException("Song seconds should be between 0 and 59.");
                this.seconds = value;
            }
        }


    }
}
