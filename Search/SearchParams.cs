using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radio.Search
{
    public class SearchParams
    {
        public String Name { get; private set; }
        public String Artist { get; private set; }

        public SearchParams()
        {

        }

        public SearchParams(String name)
        {
            this.Name = name;
        }
    }
}
