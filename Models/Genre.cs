using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;

namespace radio.Models
{
    [Serializable]
    public class Genre
    {
        [XmlElement]
        public String genre { get; set; }

        public Genre()
        {

        }

        public Genre(String genre)
        {
            this.genre = genre;
        }
    }
}
