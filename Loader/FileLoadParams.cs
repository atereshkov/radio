using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radio.Loader
{
    public class FileLoadParams : LoadParams
    {
        public string Filename { get; set; }

        public FileLoadParams()
        {

        }

        public FileLoadParams(string filename)
        {
            this.Filename = filename;
        }

    }
}
