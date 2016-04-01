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

namespace radio.IO
{
    class Saver
    {
        public static void SaveToFile(string filename, ObservableCollection<Song> songs)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Song>));

            string serialization;
            using (StreamWriter writer = new StreamWriter(filename, false))
            {
                serializer.Serialize(writer, songs);
                serialization = writer.ToString();
            }
        }

        public static void CreateEmpytFile(string filename)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false))
            {
                file.Write("");
            }
        }

    }
}
