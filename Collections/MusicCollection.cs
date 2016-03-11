using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;

namespace radio
{
    class MusicCollection : ISearcher<Song>
    {
        private ObservableCollection<Song> songs = new ObservableCollection<Song>();
        private string name;

        public MusicCollection()
        {

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

    }
}
