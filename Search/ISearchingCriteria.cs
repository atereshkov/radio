using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using radio.Models;

namespace radio.Search
{
    public interface ISearchingCriteria<T>
    {
        T checkCriteria(Song song);
    }
}
