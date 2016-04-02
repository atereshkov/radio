using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

using radio.Models;
using radio.Saver;

namespace radio
{
    class ToFileSaver : IMusicCollectionSaver
    {
        public string Filename { get; set; }
        public ObservableCollection<Song> Songs { get; set; }

        public ToFileSaver(FileSaveParams fileSaveParams)
        {
            this.Filename = fileSaveParams.Filename;
            this.Songs = fileSaveParams.Songs;
        }

        public void Save()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Song>));

            string serialization;
            using (StreamWriter writer = new StreamWriter(Filename, false))
            {
                serializer.Serialize(writer, Songs);
                serialization = writer.ToString();
            }
        }

    }
}
