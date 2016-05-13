using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;

namespace radio
{
    [Serializable]
    public class TrackOrder
    {
        [XmlAttribute]
        public int ID { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string Artist { get; set; }

        public TrackOrder() { }

        public TrackOrder(int id, string name, string artist)
        {
            this.ID = id;
            this.Name = name;
            this.Artist = artist;
        }

    }
}
