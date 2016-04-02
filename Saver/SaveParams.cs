using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using radio.Models;

namespace radio.Saver
{
    abstract class SaveParams
    {
        public string Filename { get; set; }
        public ObservableCollection<Song> Songs { get; set; }

        public SaveParams() { }

        public SaveParams(string filename, ObservableCollection<Song> songs)
        {
            this.Filename = filename;
            this.Songs = songs;
        }

    }
}
