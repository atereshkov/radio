using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using radio.Models;

namespace radio.Search
{
    public class NameSearchCriteria : ISearchingCriteria<bool>
    {
        public string Name { get; set; }

        public NameSearchCriteria()
        {

        }

        public NameSearchCriteria(String name)
        {
            this.Name = name;
        }

        public bool checkCriteria(Song song)
        {
            if (song.Name.ToLower().Contains(Name.ToLower()))
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
