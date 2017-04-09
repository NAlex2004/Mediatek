using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using LibMediatek.Classes.Items;
using LibMediatek.Interfaces;

namespace LibMediatek.Classes.Collections
{
    public class MusicArray: IMediaCollection<MusicTrack>
    {
        protected MusicTrack[] Tracks;
        protected int Index = -1;

        public MusicArray(MusicTrack[] tracks)
        {
            Tracks = tracks;
        }

        public IEnumerator<MusicTrack> GetEnumerator()
        {
            foreach (MusicTrack musicTrack in Tracks)
            {
                yield return musicTrack;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            if (Index < Tracks.Length - 1)
            {
                Index++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            Index = -1;
        }

        public MusicTrack Current
        {
            get { return Tracks[Index]; }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public IMediaItem this[int index]
        {
            get { return Tracks[index]; }
        }

        public bool MovePrevious()
        {
            if (Index >= 0)
            {
                Index--;
                return true;
            }
            return false;
        }

        public IEnumerable<MusicTrack> Find(Func<MusicTrack, bool> searchFunc)
        {
            return Tracks.Where(searchFunc);
        }
    }
}