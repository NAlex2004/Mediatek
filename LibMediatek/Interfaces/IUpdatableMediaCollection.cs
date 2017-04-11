using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibMediatek.Interfaces
{
    interface IUpdatableMediaCollection<in T> where T: IMediaItem
    {
        T this[int index] { set; }
    }
}
