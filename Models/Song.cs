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
        public string Path { get; set; }

        public Song() { }

        public Song(string Name, string Artist, int Duration, List<Tag> Tags, List<Genre> Genres, int Year)
        {
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

    }
}
