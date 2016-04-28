using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radio.Search
{
    public class ArtistSearchCriteria : ISearchingCriteria<String>
    {
        public string Artist { get; set; }

        public ArtistSearchCriteria()
        {

        }

        public ArtistSearchCriteria(String artist)
        {
            this.Artist = artist;
        }

        public new string getCriteria()
        {
            return Artist;
        }

    }
}
