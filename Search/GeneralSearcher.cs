using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using radio.Models;

namespace radio.Search
{
    public class GeneralSearcher : ISearcher<Song, String>
    {
        public GeneralSearcher()
        {

        }

        public ObservableCollection<Song> Search(Dictionary<string, ISearchingCriteria<String>> criteria, ObservableCollection<Song> listToSearch)
        {
            ObservableCollection<Song> searchResults = new ObservableCollection<Song>();

            foreach (KeyValuePair<string, ISearchingCriteria<String>> kvp in criteria)
            {
                foreach (Song song in listToSearch)
                {
                    if ((song.Name.Contains(kvp.Value.getCriteria()) || 
                        song.Artist.Contains(kvp.Value.getCriteria())) && 
                        !searchResults.Contains(song))
                    {
                        searchResults.Add(song);
                    }
                }
            }

            return searchResults;
        }
    }
}
