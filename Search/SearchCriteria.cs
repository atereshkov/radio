using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radio.Search
{
    public abstract class SearchCriteria
    {
        public string Criteria { get; set; }

        public string getCriteria()
        {
            return Criteria;
        }
    }
}
