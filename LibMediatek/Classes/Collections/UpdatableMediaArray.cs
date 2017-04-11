using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibMediatek.Interfaces;
using LibMediatek.Classes;
using LibMediatek.Classes.Collections;
using LibMediatek.Classes.Items;
using LibMediatek.Classes.Factories;

namespace LibMediatek.Classes.Collections
{
    /// <summary>
    /// array of IMediaItem. items can be changed by this[index]
    /// </summary>
    public class UpdatableMediaArray<T> : MediaArray<T> where T: IMediaItem
    {
        public UpdatableMediaArray(T[] tracks): base(tracks)
        {
        }

        public override T this[int index]
        {
            get
            {
                return Tracks[index];
            }

            set
            {
                Tracks[index] = value;
            }
        }

    }
}
