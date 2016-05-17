using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;

using radio.Models;
using radio.Loader;
using radio.Search;

namespace radio.Collections
{
    public class MusicCollection 
    {
        public string Name { get; set; }

        public ObservableCollection<Song> Songs { get; set; }

        public MusicCollection()
        {
            this.Songs = new ObservableCollection<Song>();
        }

        public MusicCollection (ObservableCollection<Song> songs, string name)
        {
            this.Songs = songs;
            this.Name = name;
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

        public int getDuration()
        {
            int duration = 0;
            foreach (Song song in Songs)
            {
                duration += song.Duration;
            }

            return duration;
        }

        public int Count()
        {
            return Songs.Count();
        }

        public string getStringDuration()
        {
            TimeSpan time = TimeSpan.FromSeconds(getDuration());
            return time.ToString(@"hh\:mm\:ss");
        }

        public void Clear()
        {
            Songs.Clear();
        }

    }
}
