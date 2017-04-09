using System;
using System.Collections.Generic;

namespace LibMediatek.Interfaces
{
    public interface IMediaRepository<T> : IEnumerable<T> where T: IMediaItem
    {
        T this[int index] { get; }
        void Clear();
        void Add(T item);
        bool Remove(T item);
        /// some kind of update
        bool Replace(T oldItem, T newItem);
        IEnumerable<T> Find(Func<T, bool> searchFunc);
    }
}