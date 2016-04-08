using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using radio.Models;

namespace radio.Sort
{
    public class NameComparer : IComparer<Song>
    {
        int IComparer<Song>.Compare(Song x, Song y)
        {
            return x.Name.ToLower().CompareTo(y.Name.ToLower());
        }

    }
}
