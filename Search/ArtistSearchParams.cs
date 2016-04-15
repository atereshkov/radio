using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radio.Search
{
    public class ArtistSearchParams
    {
        public String Artist { get; private set; }

        public ArtistSearchParams()
        {

        }

        public ArtistSearchParams(String artist)
        {
            this.Artist = artist;
        }
    }
}
