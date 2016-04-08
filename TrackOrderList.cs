using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radio
{
    class TrackOrderList
    {
        public List<TrackOrder> trackOrders { get; set; }

        public TrackOrderList()
        {
            trackOrders = new List<TrackOrder>();
        }

        public void add(TrackOrder trackOrder)
        {
            trackOrders.Add(trackOrder);
        }

    }
}
