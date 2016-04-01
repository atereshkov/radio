using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using radio.Models;

namespace radio.Sort
{
    public class SortByArtist : ISortingStrategy
    {
        public void Sort<Song>(ObservableCollection<Song> listToSort)
        {
            Console.WriteLine("Выполняется алгоритм стратегии 2.");
        }
    }
}
