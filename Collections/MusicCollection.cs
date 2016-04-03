using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;

using radio.Models;
using radio.Loader;
using radio.Search;
using radio.Interfaces;

namespace radio.Collections
{
    class MusicCollection : ISearcher<Song>
    {
        private string name;

        public ObservableCollection<Song> Songs { get; set; }

        public MusicCollection()
        {
            this.Songs = new ObservableCollection<Song>();
        }

        public MusicCollection (ObservableCollection<Song> songs, string name)
        {
            this.Songs = songs;
            this.name = name;
        }

        public Song Search(SearchParams searchParams)
        {
            return new Song();
        }

        public void Add(Song song)
        {
            Songs.Add(song);
        }

        public void Remove(Song song)
        {
            if (Songs.Contains(song))
            {
                Songs.Remove(song);
            }
        }

    }
}
