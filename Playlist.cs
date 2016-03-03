using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;

namespace radio
{
    class Playlist
    {
        private ObservableCollection<Song> Passwords = new ObservableCollection<Song>();
        public int Duration { get; private set; }
        private string name;

        public Playlist()
        {

        }

    }
}
