using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using LibMediatek.Classes.Items;
using LibMediatek.Interfaces;
using LibMediatek.Classes.Collections.Abstract;

namespace LibMediatek.Classes.Collections
{
    /// <summary>
    /// array of IMediaItem(s), readonly
    /// </summary>
    public class MediaArray<T>: MediaCollection<T> where T: IMediaItem
    {
        protected T[] Tracks;

        public MediaArray(T[] tracks)
        {
            Tracks = tracks;
        }

        public override IEnumerator<T> GetEnumerator()
        {
            foreach (T musicTrack in Tracks)
            {
                yield return musicTrack;
            }
        }

        public override void Dispose()
        {

        }

        public override T Current
        {
            get { return Tracks[Index]; }
        }

        public override T this[int index]
        {
            get { return Tracks[index]; }        
            set {}
        }

        public override IEnumerable<T> Find(Func<T, bool> searchFunc)
        {
            return Tracks.Where(searchFunc);
        }
    }
}