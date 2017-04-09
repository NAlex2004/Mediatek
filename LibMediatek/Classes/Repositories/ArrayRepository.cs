using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using LibMediatek.Interfaces;

namespace LibMediatek.Classes.Repositories
{
    public class ArrayRepository<T> : IMediaRepository<T> where T: IMediaItem
    {
        protected T[] Items;

        public ArrayRepository(T[] items)
        {
            Items = items;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in Items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T this[int index]
        {
            get { return Items[index]; }
        }

        /// <summary>
        /// Does nothing
        /// </summary>
        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public bool Replace(T oldItem, T newItem)
        {
            int ind = Array.FindIndex(Items, x => x.Equals(oldItem));
            if (ind >= 0)
            {
                Items[ind] = newItem;
            }

            return (ind >= 0);
        }

        public IEnumerable<T> Find(Func<T, bool> searchFunc)
        {
            return Items.Where(searchFunc);
        }
    }
}