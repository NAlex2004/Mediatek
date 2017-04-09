using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using LibMediatek.Interfaces;

namespace LibMediatek.Classes.Collections
{
    public class MediaCollection<T> : IMediaCollection<T> where T: class, IMediaItem
    {
        protected IMediaRepository<T> Repository;
        private int _index = -1;

        protected MediaCollection()
        {
        }

        public virtual T this[string title]
        {
            get
            {
                var items = Repository.Find(x => x.Title.Equals(title));
                if (items != null)
                    return items.FirstOrDefault();
                return null;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Repository.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Dispose()
        {
            IDisposable rep = Repository as IDisposable;
            if (rep != null)
                rep.Dispose();
        }

        public bool MoveNext()
        {
            return (++_index < Repository.Count());
        }

        public void Reset()
        {
            _index = -1;
        }

        public T Current
        {
            get { return Repository[_index]; }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        IMediaItem IMediaCollection<T>.this[int index]
        {
            get { return Repository[index]; }
        }
        public void Add(T item)
        {
            Repository.Add(item);
        }

        public bool Remove(T item)
        {
            return Repository.Remove(item);
        }

        public bool MovePrevious()
        {
            if (_index >= 0)
                _index--;
            return (_index >= 0);
        }

        public IEnumerable<T> Find(Func<T, bool> searchFunc)
        {
            return Repository.Find(searchFunc);
        }
    }
}