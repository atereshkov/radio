using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using radio.Models;

namespace radio.Search
{
    public class SearchByName : ISearchingStrategy<Song>
    {
        public ObservableCollection<Song> Search(SearchParams searchParams, ObservableCollection<Song> listToSearch)
        {
            ObservableCollection<Song> searchResults = new ObservableCollection<Song>();

            foreach (Song song in listToSearch)
            {
                if (song.Name.ToLower().Contains(searchParams.Name.ToLower()))
                {
                    searchResults.Add(song);
                }
            }

            //ObservableCollection<Song> listItems = listToSearch.Where(i => i.Name.Equals(searchParams.Name));

            return searchResults;
        }
    }
}
