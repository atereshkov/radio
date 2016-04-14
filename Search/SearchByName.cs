using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using radio.Models;

namespace radio.Search
{
    public class SearchByName : ISearchingStrategy
    {
        public ObservableCollection<Song> Search<Song>(SearchParams searchParams, ObservableCollection<Song> listToSearch)
        {
            /*
            List<Song> tmp = new List<Song>(listToSearch);
            listToSearch.Clear();

            tmp.Sort((IComparer<Song>)new NameComparer());

            foreach (Song song in tmp) // for notify observablecollection
            {
                listToSort.Add(song);
            }
            */

            List<Song> searchResults = new List<Song>();

            foreach (Song song in listToSearch)
            {
                //if (song.Name.ToLower().Equals(searchParams.Name.ToLower()))
                {
                    //searchResults.Add(song);
                }
            }

            //ObservableCollection<Song> listItems = listToSearch.Where(i => i.Name == searchParams.Name);

            return null;
        }
    }
}
