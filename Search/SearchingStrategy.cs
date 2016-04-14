using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using radio.Models;

namespace radio.Search
{
    class SortingStrategy
    {
        private ISearchingStrategy _strategy;
        private ObservableCollection<Song> listToSearch;
        private SearchParams searchParams;

        public SortingStrategy()
        {

        }

        public SortingStrategy(ISearchingStrategy strategy, ObservableCollection<Song> listToSearch, SearchParams searchParams)
        {
            _strategy = strategy;
            this.listToSearch = listToSearch;
            this.searchParams = searchParams;
        }

        public void SetStrategy(ISearchingStrategy strategy, ObservableCollection<Song> listToSearch, SearchParams searchParams)
        {
            _strategy = strategy;
            this.listToSearch = listToSearch;
            this.searchParams = searchParams;
        }

        public void Search()
        {
            _strategy.Search(searchParams, listToSearch);
        }
    }
}
