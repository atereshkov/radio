using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;

namespace radio.Models
{
    [Serializable]
    public class Song
    {
        [XmlAttribute]
        public int ID { get; set; }

        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public string Artist { get; set; }
        [XmlAttribute]
        public int Duration { get; set; }
        [XmlAttribute]
        public string Album { get; set; }
        [XmlAttribute]
        public int Year { get; set; }

        [XmlArrayItem(Type = typeof(Tag))]
        public List<Tag> Tags { get; set; }

        [XmlArrayItem(Type = typeof(Genre))]
        public List<Genre> Genres { get; set; }

        [XmlIgnore]
        private string _stringTags;

        [XmlIgnore]
        public string StringTags
        {
            set { _stringTags = value; }
            get { return GetStringTags(Tags); }
        }

        [XmlIgnore]
        private string _stringGenres;

        [XmlIgnore]
        public string StringGenres
        {
            set { _stringGenres = value; }
            get { return GetStringGenres(Genres); }
        }

        [XmlIgnore]
        public string Path { get; set; }

        [XmlIgnore]
        private string _stringDuration;

        [XmlIgnore]
        public string StringDuration 
        {
            set { _stringDuration = value; } 
            get { return getStringDuration(Duration); }
        }

        public Song() { }

        public Song(int ID, string Name, string Artist, int Duration, List<Tag> Tags, List<Genre> Genres, int Year)
        {
            this.ID = ID;
            this.Name = Name;
            this.Artist = Artist;
            this.Duration = Duration;
            this.Tags = Tags;
            this.Genres = Genres;
            this.Year = Year;
        }

        public override string ToString()
        {
            return Name;
        }

        private string getStringDuration(int seconds)
        {
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            return time.ToString(@"hh\:mm\:ss");
        }

        public string GetStringTags(List<Tag> tags)
        {
            StringBuilder sb = new StringBuilder();
            foreach(Tag tag in tags)
            {
                sb.Append(tag + ", ");
            }

            return sb.ToString();
        }

        public string GetStringGenres(List<Genre> genres)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Genre genre in genres)
            {
                sb.Append(genre + ", ");
            }

            return sb.ToString();
        }

    }
}
