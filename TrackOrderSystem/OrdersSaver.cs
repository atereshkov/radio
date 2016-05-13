using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

using radio.TrackOrderSystem;
using radio.Saver;

namespace radio.TrackOrderSystem
{
    public class OrdersSaver : ITrackOrderSaver
    {
        public string Filename { get; set; }
        public ObservableCollection<TrackOrder> TrackOrders { get; set; }

        public OrdersSaver(TrackOrderSaveParams fileSaveParams)
        {
            this.Filename = fileSaveParams.Filename;
            this.TrackOrders = fileSaveParams.TrackOrders;
        }

        public void Save()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<TrackOrder>));

            string serialization;
            using (StreamWriter writer = new StreamWriter(Filename, false))
            {
                serializer.Serialize(writer, TrackOrders);
                serialization = writer.ToString();
            }
        }
    }
}
