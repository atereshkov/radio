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
    public class SortByDuration : ISortingStrategy
    {
        public void Sort<Song>(ObservableCollection<Song> listToSort)
        {
            List<Song> tmp = new List<Song>();

            foreach (Song song in listToSort)
            {
                tmp.Add(song);
            }

            DurationComparer comparer = new DurationComparer();
            //tmp.Sort(comparer);

            //var orderedSm = tmp.OrderBy(x => x.Duration).ToList();

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
