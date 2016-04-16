using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using radio.Models;

namespace radio.Search
{
    public class GeneralSearcher : ISearcher<Song>
    {
        public GeneralSearcher()
        {

        }

        public ObservableCollection<Song> Search(Dictionary<string, SearchCriteria> criteria, ObservableCollection<Song> listToSearch)
        {
            ObservableCollection<Song> searchResults = new ObservableCollection<Song>();

            foreach (KeyValuePair<string, SearchCriteria> kvp in criteria)
            {
                foreach (Song song in listToSearch)
                {
                    if (song.Name.Contains(kvp.Value.getCriteria()) && !searchResults.Contains(song)) // TODO: ...
                    {
                        searchResults.Add(song);
                    }
                }
            }

            return searchResults;
        }
    }
}
