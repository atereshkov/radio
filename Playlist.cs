using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;

namespace radio
{
    class Playlist : ISearcher<Song>
    {
        private ObservableCollection<Song> songs = new ObservableCollection<Song>();
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

        public void add(Song song)
        {
            songs.Add(song);
        }

        public void remove(Song song)
        {
            if (songs.Contains(song))
                songs.Remove(song);
        }

        public Song search()
        {
            return new Song();
        }

    }
}
