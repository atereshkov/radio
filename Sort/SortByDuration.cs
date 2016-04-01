using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using radio.Models;
using radio.Collections;

namespace radio.Sort
{
    public class SortByDuration : ISortingStrategy  // IComparer<Song>
    {
        public void Sort<Song>(ObservableCollection<Song> listToSort)
        {
            
        }

        /*
        public int Compare(Song x, Song y)
        {
            if (x.Duration.CompareTo(y.Duration) != 0)
            {
                return x.Duration.CompareTo(y.Duration);
            }
            else if (x.Duration.CompareTo(y.Duration) != 0)
            {
                return x.Duration.CompareTo(y.Duration);
            }
            else if (x.Duration.CompareTo(y.Duration) != 0)
            {
                return x.Duration.CompareTo(y.Duration);
            }
            else
            {
                return 0;
            }
        }
        */

    }
}
