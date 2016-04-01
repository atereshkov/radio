using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radio
{
    public class LoadParams
    {
        public string Filename { get; set; }

        public LoadParams() { }

        public LoadParams(string filename)
        {
            this.Filename = filename;
        }

    }
}
