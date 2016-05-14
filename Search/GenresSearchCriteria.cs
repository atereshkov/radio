using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using radio.Models;

namespace radio.Search
{
    public class GenresSearchCriteria : ISearchingCriteria<bool>
    {
        public string Genre { get; set; }

        public GenresSearchCriteria()
        {

        }

        public GenresSearchCriteria(String genre)
        {
            this.Genre = genre;
        }

        public bool checkCriteria(Song song)
        {
            bool result = false;

            foreach (Genre songGenre in song.Genres)
            {
                if (songGenre.ToString().ToLower().Contains(Genre.ToLower()))
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
