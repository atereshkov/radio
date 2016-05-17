using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;

using radio.Models;

namespace radio.Collections
{
    class Playlist : MusicCollection
    {
        public int Duration { get; private set; }
        private string name;

        public Playlist()
        {

        }

        public Playlist(string name, int Duration)
        {
            this.name = name;
            this.Duration = Duration;
        }

        public Playlist(ObservableCollection<Song> songs, string name)
        {
            this.Songs = songs;
            this.Name = name;
        }

    }
}
