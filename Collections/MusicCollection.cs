using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;

using radio.Models;
using radio.Interfaces;

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

        public MusicCollection (string filename, string name)
        {
            Songs = Loader.ReadFromFile(filename);
            this.name = name;
        }

        public ObservableCollection<Song> getSongs ()
        {
            return Songs;
        }

        public Song Search()
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

        public void SortByName()
        {

        }

        public void SortByArtist()
        {

        }

        public void SortByDuration()
        {

        }

        public void SortByYear()
        {

        }

    }
}
