using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using radio.Models;

namespace radio.Sort
{
    public class DurationComparer : IComparer<Song>
    {
        /*
        public int Compare(Song c1, Song c2)
        {
            return c1.Duration.CompareTo(c2.Duration);
        }
        */

        int IComparer<Song>.Compare(Song x, Song y)
        {
            if (x.Duration < y.Duration)
                return 1;
            if (x.Duration > y.Duration)
                return -1;
            else return 0;
        }

    }
}
