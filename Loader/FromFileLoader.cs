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

using radio.Models;
using radio.Loader;

namespace radio
{
    public class FromFileLoader : ILoader<ObservableCollection<Song>>
    {
        public string Filename { get; set; }

        public FromFileLoader(FileLoadParams fileLoadParams)
        {
            this.Filename = fileLoadParams.Filename;
        }

        public ObservableCollection<Song> Load()
        {
            ObservableCollection<Song> songs = new ObservableCollection<Song>();

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Song>));

                using (Stream reader = File.Open(Filename, FileMode.Open))
                {
                    songs = (ObservableCollection<Song>)serializer.Deserialize(reader);
                }

            }
            catch (System.IO.IOException e)
            {
                
            }

            return songs;
        }
    }
}
