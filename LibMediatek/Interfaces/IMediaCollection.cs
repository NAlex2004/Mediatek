using System;
using System.Collections.Generic;

namespace LibMediatek.Interfaces
{
    public interface IMediaCollection<out T> : IEnumerable<T>, IEnumerator<T> where T : IMediaItem
    {
        T this[int index] { get; }
        bool MovePrevious();
        IEnumerable<T> Find(Func<T, bool> searchFunc);
    }
}