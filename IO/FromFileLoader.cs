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
using radio.Interfaces;

namespace radio.IO
{
    public class FromFileLoader : ILoader<ObservableCollection<Song>>
    {

        public FromFileLoader(LoadParams loadParams)
        {
            
        }

        public ObservableCollection<Song> Load(LoadParams loadParams)
        {
            ObservableCollection<Song> songs = new ObservableCollection<Song>();

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Song>));

                using (Stream reader = File.Open(loadParams.Filename, FileMode.Open))
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
