using System;
using System.Collections;
using System.Collections.Generic;
using LibMediatek.Interfaces;

namespace LibMediatek.Classes.Collections
{
    public abstract class MediaCollection<T> : IMediaCollection<T> where T: IMediaItem
    {
        protected int Index = -1;
        public virtual int Count { get; protected set; }

        public abstract IEnumerator<T> GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public abstract void Dispose();

        public bool MoveNext()
        {
            if (Index < Count - 1)
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

        public abstract T Current { get; }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public abstract T this[int index] { get; }

        public bool MovePrevious()
        {
            if (Index >= 0)
            {
                Index--;
            }

            return (Index >= 0);
        }

        public abstract IEnumerable<T> Find(Func<T, bool> searchFunc);
    }
}