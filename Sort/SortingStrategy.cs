using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using radio.Models;

namespace radio.Sort
{
    class SortingStrategy
    {
        private ISortingStrategy _strategy;
        private ObservableCollection<Song> listToSort;

        public SortingStrategy()
        {

        }

        public SortingStrategy(ISortingStrategy strategy, ObservableCollection<Song> listToSort)
        {
            _strategy = strategy;
            this.listToSort = listToSort;
        }

        public void SetStrategy(ISortingStrategy strategy, ObservableCollection<Song> listToSort)
        {
            _strategy = strategy;
            this.listToSort = listToSort;
        }

        public void Sort()
        {
            _strategy.Sort(listToSort);
        }
    }
}
