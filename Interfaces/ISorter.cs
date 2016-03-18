using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radio.Interfaces
{
    interface ISorter<T>
    {
        void sortByName();
        void sortByDuration();
        void sortByArtist();
        void sortByYear();
    }
}
