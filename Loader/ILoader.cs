using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radio.Loader
{
    interface ILoader <T>
    {
        T Load();
    }
}
