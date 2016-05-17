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
        private SortOrder order;

        public SortingStrategy()
        {

        }

        public SortingStrategy(ISortingStrategy strategy, ObservableCollection<Song> listToSort, SortOrder order)
        {
            _strategy = strategy;
            this.listToSort = listToSort;
            this.order = order;
        }

        public void SetStrategy(ISortingStrategy strategy, ObservableCollection<Song> listToSort, SortOrder order)
        {
            _strategy = strategy;
            this.listToSort = listToSort;
            this.order = order;
        }

        public void Sort()
        {
            if (listToSort != null)
                _strategy.Sort(listToSort, order);
        }
    }
}
