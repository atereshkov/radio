using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using radio.Models;

namespace radio.Search
{
    class SearchingStrategy
    {
        private ISearchingStrategy<Song> _strategy;
        private ObservableCollection<Song> listToSearch;
        private SearchParams searchParams;

        public SearchingStrategy()
        {

        }

        public SearchingStrategy(ISearchingStrategy<Song> strategy, ObservableCollection<Song> listToSearch, SearchParams searchParams)
        {
            _strategy = strategy;
            this.listToSearch = listToSearch;
            this.searchParams = searchParams;
        }

        public void SetStrategy(ISearchingStrategy<Song> strategy, ObservableCollection<Song> listToSearch, SearchParams searchParams)
        {
            _strategy = strategy;
            this.listToSearch = listToSearch;
            this.searchParams = searchParams;
        }

        public ObservableCollection<Song> Search()
        {
            return _strategy.Search(searchParams, listToSearch);
        }
    }
}
