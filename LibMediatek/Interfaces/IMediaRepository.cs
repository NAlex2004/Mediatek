using System.Collections.Generic;

namespace LibMediatek.Interfaces
{
    public interface IMediaRepository : IEnumerable<IMediaItem>
    {
        IMediaItem this[int index] { get; }
        IMediaItem this[string title] { get; }
        void Clear();
        void Add(IMediaItem item);
        bool Remove(IMediaItem item);
        /// some kind of update
        bool Replace(IMediaItem oldItem, IMediaItem newItem);
    }
}