using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radio
{
    class Song
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public int Duration { get; set; }
        public string Album { get; set; }
        public int Year { get; set; }
        public string Tags { get; set; }
        public string Path { get; set; }

        public Song() { }

        public Song(string Name, string Artist, int Duration, string Tags, int Year)
        {
            this.Name = Name;
            this.Artist = Artist;
            this.Duration = Duration;
            this.Tags = Tags;
            this.Year = Year;
        }

    }
}
