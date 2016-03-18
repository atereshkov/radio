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
        public ObservableCollection<Song> songs { get; set; }
        private string name;

        public MusicCollection()
        {
            this.songs = new ObservableCollection<Song>();
        }

        public MusicCollection (string filename, string name)
        {
            songs = Loader.ReadFromFile(filename);
            this.name = name;
        }

        public ObservableCollection<Song> getSongs ()
        {
            return songs;
        }

        public Song search()
        {
            return new Song();
        }

        public void add(Song song)
        {
            songs.Add(song);
        }

        public void sortByName()
        {

        }

        public void sortByArtist()
        {

        }

        public void sortByDuration()
        {

        }

        public void sortByYear()
        {

        }

    }
}
