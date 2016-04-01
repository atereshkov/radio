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
        public ToFileSaver()
        {

        }

        public void Save(SaveParams saveParams)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Song>));

            string serialization;
            using (StreamWriter writer = new StreamWriter(saveParams.Filename, false))
            {
                serializer.Serialize(writer, saveParams.Songs);
                serialization = writer.ToString();
            }
        }

    }
}
