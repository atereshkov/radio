using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using radio.Models;

namespace radio.Search
{
    public class GeneralSearcher : ISearcher<Song, bool>
    {
        public GeneralSearcher()
        {

        }

        public ObservableCollection<Song> Search(Dictionary<string, ISearchingCriteria<bool>> criteria, ObservableCollection<Song> listToSearch)
        {
            ObservableCollection<Song> searchResults = new ObservableCollection<Song>();

            foreach (KeyValuePair<string, ISearchingCriteria<bool>> kvp in criteria)
            {
                foreach (Song song in listToSearch)
                {
                    if (kvp.Value.checkCriteria(song) && !searchResults.Contains(song))
                    {
                        searchResults.Add(song);
                    }
                }
            }

            return searchResults;
        }
    }
}
