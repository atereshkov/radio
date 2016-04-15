using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radio.Search
{
    public class NameSearchParams : SearchParams
    {
        public String Name { get; private set; }

        public NameSearchParams()
        {

        }

        public NameSearchParams(String name)
        {
            this.Name = name;
        }
    }
}
