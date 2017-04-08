using System;
using System.Collections.Generic;

namespace LibMediatek.Interfaces
{
    public interface IMediaRepository : IEnumerable<IMediaItem>
    {
        void Clear();
        void Add(IMediaItem item);
        bool Remove(IMediaItem item);
        /// some kind of update
        bool Replace(IMediaItem oldItem, IMediaItem newItem);
        IEnumerable<IMediaItem> Find(Func<IMediaItem, bool> searchFunc);
    }
}