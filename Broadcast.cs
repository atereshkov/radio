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
        public int AirTime { get; private set; }

        private string _stringAirtime;
        public string StringAirtime
        {
            set { _stringAirtime = value; }
            get { return getStringAirTime(AirTime); }
        }

        private bool isPaused;

        private DispatcherTimer timer = new DispatcherTimer();
        private DispatcherTimer airtimeTimer = new DispatcherTimer();

        public Broadcast()
        {
           
        }

        public Broadcast(Playlist playlist)
        {
            this.Playlist = playlist;
            this.AirTime = 0;

            timer.Tick += new EventHandler(timerTick);
            timer.Interval = new TimeSpan(0, 0, 1);
            airtimeTimer.Tick += new EventHandler(airtimeTick);
            airtimeTimer.Interval = new TimeSpan(0, 0, 1);
        }

        public void Start()
        {
            State = true;
            timer.Start();
            airtimeTimer.Start();
        }

        public void Stop()
        {
            State = false;
            timer.Stop();
            airtimeTimer.Stop();
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

        private void airtimeTick(object sender, EventArgs e)
        {
            AirTime++;
        }

        private string getStringAirTime(int seconds)
        {
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            return time.ToString(@"hh\:mm\:ss");
        }

    }
}
