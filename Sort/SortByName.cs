using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using radio.Models;

namespace radio.Sort
{
    public class SortByName : ISortingStrategy
    {
        public void Sort<Song>(ObservableCollection<Song> listToSort, SortOrder order)
        {
            List<Song> tmp = new List<Song>(listToSort);
            listToSort.Clear();

            tmp.Sort((IComparer<Song>)new NameComparer());
            if (order != SortOrder.Ascending)
                tmp.Reverse();

            foreach (Song song in tmp) // for notify observablecollection
            {
                listToSort.Add(song);
            }
        }
    }
}
