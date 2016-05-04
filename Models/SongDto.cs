using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radio.Models
{
    public class SongDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public int Duration { get; set; }
        public string Album { get; set; }
        public int Year { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Genre> Genres { get; set; }

        public string Path { get; set; }

        private string _stringDuration;

        public string StringDuration 
        {
            set { _stringDuration = value; } 
            get { return getStringDuration(Duration); }
        }

        public SongDto() { }

        public SongDto(int ID, string Name, string Artist, int Duration, List<Tag> Tags, List<Genre> Genres, int Year)
        {
            this.ID = ID;
            this.Name = Name;
            this.Artist = Artist;
            this.Duration = Duration;
            this.Tags = Tags;
            this.Genres = Genres;
            this.Year = Year;
        }

        public string getStringDuration(int seconds)
        {
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            return time.ToString(@"hh\:mm\:ss");
        }
    }
}
