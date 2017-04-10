using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibMediatek.Interfaces;
using LibMediatek.Classes.Items;
using LibMediatek.Classes.Collections;
using LibMediatek.Classes.Factories;
using LibMediatek.Classes.Collections.Abstract;

namespace LibMediatek.Classes.Collections
{
    public class Series
    {
        public IWritableMediaCollection<Video> Videos { get; protected set; }
        public IWritableMediaCollection<Photo> Images { get; protected set; } 

        public Series(MediaFactory factory)
        {
            Videos = factory.CreateVideos() as IWritableMediaCollection<Video>;
            Images = factory.CreateImages() as IWritableMediaCollection<Photo>;
        }
    }
}
