using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using radio.Models;

namespace radio.Search
{
    public class ArtistSearcher : ISearchingStrategy<Song>
    {
        public ObservableCollection<Song> Search(ArtistSearchParams searchParams, ObservableCollection<Song> listToSearch)
        {
            ObservableCollection<Song> searchResults = new ObservableCollection<Song>();

            foreach (Song song in listToSearch)
            {
                if (song.Artist.ToLower().Contains(searchParams.Artist.ToLower()))
                {
                    searchResults.Add(song);
                }
            }

            return searchResults;
        }

    }
}
