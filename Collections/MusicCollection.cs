using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;

using radio.Models;
using radio.Interfaces;
using radio.Search;
using radio.IO;

namespace radio.Collections
{
    class MusicCollection : ISearcher<Song>, ISorter<Song>
    {
        private string name;

        public ObservableCollection<Song> Songs { get; set; }

        public MusicCollection()
        {
            this.Songs = new ObservableCollection<Song>();
        }

        public MusicCollection (LoadParams loadParams, string name)
        {
            ILoader<ObservableCollection<Song>> loader = new FromFileLoader(loadParams);
            Songs = loader.Load(loadParams);
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

        public void Sort()
        {

        }

    }
}
