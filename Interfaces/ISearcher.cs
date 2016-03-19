using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radio
{
    interface ISearcher <T>
    {
        T Search();
    }
}
