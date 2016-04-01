using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using radio.Search;

namespace radio
{
    interface ISearcher <T>
    {
        T Search(SearchParams searchParams);
    }
}
