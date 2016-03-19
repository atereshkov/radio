using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radio.Interfaces
{
    interface ISorter<T>
    {
        void SortByName();
        void SortByDuration();
        void SortByArtist();
        void SortByYear();
    }
}
