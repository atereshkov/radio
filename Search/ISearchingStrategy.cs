using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace radio.Search
{
    interface ISearchingStrategy
    {
        ObservableCollection<T> Search<T>(SearchParams searchParams, ObservableCollection<T> listToSearch);
    }
}
