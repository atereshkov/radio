using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;

using radio.Saver;

namespace radio.TrackOrderSystem
{
    public class TrackOrderSaveParams
    {
        public string Filename { get; set; }
        public ObservableCollection<TrackOrder> TrackOrders { get; set; }

        public TrackOrderSaveParams() { }

        public TrackOrderSaveParams(string filename, ObservableCollection<TrackOrder> trackOrders)
        {
            this.Filename = filename;
            this.TrackOrders = trackOrders;
        }
    }
}
