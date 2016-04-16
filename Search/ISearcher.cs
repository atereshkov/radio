using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;

namespace radio.Search
{
    interface ISearcher<T>
    {
        ObservableCollection<T> Search(Dictionary<string, SearchCriteria> criteria, ObservableCollection<T> listToSearch);
    }
}
