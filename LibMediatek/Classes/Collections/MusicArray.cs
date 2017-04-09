using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using LibMediatek.Classes.Items;
using LibMediatek.Interfaces;

namespace LibMediatek.Classes.Collections
{
    public class MusicArray: MediaCollection<MusicTrack>
    {
        protected MusicTrack[] Tracks;

        public MusicArray(MusicTrack[] tracks)
        {
            Tracks = tracks;
        }

        public override IEnumerator<MusicTrack> GetEnumerator()
        {
            foreach (MusicTrack musicTrack in Tracks)
            {
                yield return musicTrack;
            }
        }

        public override void Dispose()
        {

        }

        public override MusicTrack Current
        {
            get { return Tracks[Index]; }
        }

        public override MusicTrack this[int index]
        {
            get { return Tracks[index]; }
        }

        public override IEnumerable<MusicTrack> Find(Func<MusicTrack, bool> searchFunc)
        {
            return Tracks.Where(searchFunc);
        }
    }
}