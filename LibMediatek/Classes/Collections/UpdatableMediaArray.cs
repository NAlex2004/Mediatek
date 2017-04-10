using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibMediatek.Interfaces;

namespace LibMediatek.Classes.Collections
{
    class UpdatableMediaArray<T>: MediaArray<T> where T: IMediaItem
    {
        public override T this[int index]
        {
            get { return Tracks[index]; }
            set { Tracks[index] = value; }
        }
    }
}
