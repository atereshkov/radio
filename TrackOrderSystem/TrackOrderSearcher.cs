using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using radio.Collections;
using radio.Models;

namespace radio.TrackOrderSystem
{
    public class TrackOrderSearcher
    {
        private MusicCollection musicCollection;
        private TrackOrder trackOrder;
        public Song foundedSong { get; private set; }

        public TrackOrderSearcher(MusicCollection musicCollection, TrackOrder trackOrder)
        {
            this.musicCollection = musicCollection;
            this.trackOrder = trackOrder;
        }

        public bool Search()
        {
            bool result = false;

            if (musicCollection != null)
                foreach(Song song in musicCollection.Songs)
                {
                    if (song.Artist.Equals(trackOrder.Artist) && song.Name.Equals(trackOrder.Name))
                    {
                        foundedSong = song;
                        result = true;
                        break;
                    }
                }

            return result;
        }

    }
}
