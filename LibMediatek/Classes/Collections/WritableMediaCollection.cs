using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibMediatek.Interfaces;

namespace LibMediatek.Classes.Collections
{
    public abstract class WritableMediaCollection<T> : MediaCollection<T>, IWritableMediaCollection<T> where T: IMediaItem
    {
        public abstract void Add(T item);        
        public abstract bool Remove(T item);        
        public abstract bool Replace(T oldItem, T newItem);        
        public abstract void Clear();        
    }
}
