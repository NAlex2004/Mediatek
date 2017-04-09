using System.Collections.Generic;

namespace LibMediatek.Interfaces
{
    public interface IMediaCollection<out T> : IEnumerable<T>, IEnumerator<T> where T : IMediaItem
    {
        IMediaItem this[int index] { get; }
//        void Add(IMediaItem item);
//        bool Remove(IMediaItem item);
        bool MovePrevious();
    }
}