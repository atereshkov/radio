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
        public Playlist Playlist { get; private set; }
        public Song CurrentSong { get; private set; }

        private bool isPaused;

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

        public void SetCurrentSong(Song song)
        {
            CurrentSong = song;
        }

        public void PlayNext()
        {
            CurrentSong = Playlist.Songs[0];
        }

        public void PauseSong()
        {

        }

        public void StopSong()
        {

        }

    }
}
