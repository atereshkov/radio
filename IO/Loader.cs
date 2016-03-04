using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.ObjectModel;


namespace radio
{
    class Loader
    {
        public static ObservableCollection<Song> ReadFromFile(string filename)
        {
            ObservableCollection<Song> songs = new ObservableCollection<Song>();

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Song>));

                using (Stream reader = File.Open(filename, FileMode.Open))
                {
                    songs = (ObservableCollection<Song>)serializer.Deserialize(reader);
                }

            }
            catch (System.IO.IOException e)
            {
                //  ("An error occurred: '{0}'", e);
            }

            return songs;
        }
    }
}
