using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radio.Search
{
    public class NameSearchCriteria : SearchCriteria
    {
        public string Name { get; set; }

        public NameSearchCriteria()
        {

        }

        public NameSearchCriteria(String name)
        {
            this.Name = name;
        }

        public new string getCriteria()
        {
            return Name;
        }

    }
}
