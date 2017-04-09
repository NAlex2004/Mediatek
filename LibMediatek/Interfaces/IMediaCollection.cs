using System.Collections.Generic;

namespace LibMediatek.Interfaces
{
    public interface IMediaCollection<out T> : IEnumerable<T>, IEnumerator<T> where T : IMediaItem
    {
        IMediaItem this[int index] { get; }
        bool MovePrevious();
    }
}