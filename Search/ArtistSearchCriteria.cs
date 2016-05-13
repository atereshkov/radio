using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using radio.Models;

namespace radio.Search
{
    public class ArtistSearchCriteria : ISearchingCriteria<bool>
    {
        public string Artist { get; set; }

        public ArtistSearchCriteria()
        {

        }

        public ArtistSearchCriteria(String artist)
        {
            this.Artist = artist;
        }

        public bool checkCriteria(Song song)
        {
            if (song.Artist.ToLower().Contains(Artist.ToLower()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
