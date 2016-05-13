using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using System.IO;
using System.Xml;
using System.Xml.Serialization;

using radio.Loader;

namespace radio.TrackOrderSystem
{
    public class OrdersLoader : ILoader<ObservableCollection<TrackOrder>>
    {
        public string Filename { get; set; }

        public OrdersLoader(FileLoadParams fileLoadParams)
        {
            this.Filename = fileLoadParams.Filename;
        }

        public ObservableCollection<TrackOrder> Load()
        {
            ObservableCollection<TrackOrder> trackOrders = new ObservableCollection<TrackOrder>();

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<TrackOrder>));

                using (Stream reader = File.Open(Filename, FileMode.Open))
                {
                    trackOrders = (ObservableCollection<TrackOrder>)serializer.Deserialize(reader);
                }

            }
            catch (System.IO.IOException e)
            {
                
            }

            return trackOrders;
        }
    }
}
