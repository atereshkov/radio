using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace radio.Sort
{
    interface ISortingStrategy
    {
        void Sort<T>(ObservableCollection<T> listToSort, SortOrder order);
    }
}
