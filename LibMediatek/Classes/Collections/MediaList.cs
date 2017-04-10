using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibMediatek.Classes.Collections.Abstract;
using LibMediatek.Interfaces;

namespace LibMediatek.Classes.Collections
{
    public class MediaList<T> : WritableMediaCollection<T> where T: IMediaItem
    {
        protected IList<T> Items;

        public MediaList(IList<T> items = null)
        {
            if (items == null)
                Items = new List<T>();
            else
                Items = items;
        }

        public override void Add(T item)
        {
            Items.Add(item);
        }

        public override bool Remove(T item)
        {
            return Items.Remove(item);
        }

        public override bool Replace(T oldItem, T newItem)
        {
            int i = Items.IndexOf(oldItem);
            if (i >= 0)
            {
                Items.RemoveAt(i);
                // или i-1 ??
                Items.Insert(i, newItem);
                return true;
            }

            return false;
        }

        public override void Clear()
        {
            Items.Clear();
        }

        public override IEnumerator<T> GetEnumerator()
        {
            return Items.GetEnumerator();
        }

        public override void Dispose()
        {
        }

        public override T Current
        {
            get { return Items[Index]; }
        }

        public override T this[int index]
        {
            get { return Items[index]; }           
        }

        public virtual void ReplaceAt(int index, T newItem)
        {
            Items[index] = newItem;
        }

        /// <summary>
        /// Exchange elements. 
        /// Implemented here, not in interface, because for example in database this operation has no sence
        /// </summary>
        public virtual void Exchange(int index1, int index2)
        {
            T temp = Items[index1];
            Items[index1] = Items[index2];
            Items[index2] = temp;
        }

        public override IEnumerable<T> Find(Func<T, bool> searchFunc)
        {
            return Items.Where(searchFunc);
        }
    }
}
