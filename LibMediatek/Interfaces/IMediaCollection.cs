using System;
using System.Collections.Generic;

namespace LibMediatek.Interfaces
{
    public interface IMediaCollection<T> : IEnumerable<T>, IEnumerator<T> where T : IMediaItem
    {
        T this[int index] { get; set; }
        bool MovePrevious();
        IEnumerable<T> Find(Func<T, bool> searchFunc);
    }
}