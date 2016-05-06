using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using radio.Collections;
using radio.Models;

namespace radio
{
    class Broadcast
    {
        public bool State { get; private set; }
        public Playlist Playlist { get; set; }
        public Song CurrentSong { get; private set; }

        public Broadcast()
        {

        }

        public Broadcast(Playlist playlist)
        {
            this.Playlist = playlist;
        }

        public void Start()
        {
            State = true;
        }

        public void Stop()
        {
            State = false;
        }

        public bool isOnline()
        {
            return State;
        }

        public void UpdatePlaylist(Playlist playlist)
        {
            this.Playlist = playlist;
        }

        public void setCurrentSong(Song song)
        {
            CurrentSong = song;
        }

    }
}
