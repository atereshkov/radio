using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

using radio.Collections;
using radio.Models;

namespace radio
{
    class Broadcast
    {
        public bool State { get; private set; }
        public Playlist Playlist { get; private set; }
        public Song CurrentSong { get; private set; }
        public int ListenersCount { get; private set; }

        private bool isPaused;

        private DispatcherTimer timer = new DispatcherTimer();

        public Broadcast()
        {
           
        }

        public Broadcast(Playlist playlist)
        {
            this.Playlist = playlist;

            timer.Tick += new EventHandler(timerTick);
            timer.Interval = new TimeSpan(0, 0, 1);
        }

        public void Start()
        {
            State = true;
            timer.Start();
        }

        public void Stop()
        {
            State = false;
            timer.Stop();
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

        private void timerTick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ListenersCount = rnd.Next(20, 30);
        }

    }
}
