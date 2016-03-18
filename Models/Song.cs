using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;

namespace radio
{
    [Serializable]
    public class Song
    {
        [XmlElement]
        public string Name { get; set; }
        [XmlElement]
        public string Artist { get; set; }
        [XmlElement]
        public int Duration { get; set; }
        [XmlElement]
        public string Album { get; set; }
        [XmlElement]
        public int Year { get; set; }
        [XmlArrayItem(Type = typeof(Tag))]
        public List<Tag> Tags { get; set; }
        [XmlElement]
        public string Path { get; set; }

        public Song() { }

        public Song(string Name, string Artist, int Duration, List<Tag> Tags, int Year)
        {
            this.Name = Name;
            this.Artist = Artist;
            this.Duration = Duration;
            this.Tags = Tags;
            this.Year = Year;
        }

    }
}
