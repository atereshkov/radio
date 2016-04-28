using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;

namespace radio.Search
{
    interface ISearcher<T, T2>
    {
        ObservableCollection<T> Search(Dictionary<string, ISearchingCriteria<T2>> criteria, ObservableCollection<T> listToSearch);
    }
}
