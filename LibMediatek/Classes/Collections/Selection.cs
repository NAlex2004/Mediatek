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
    public class Selection
    {
        public IMediaCollection<MusicTrack> MusicTracks { get; protected set; }
        public IMediaCollection<Photo> Images { get; protected set; }

        public Selection(MediaFactory factory)
        {
            MusicTracks = factory.CreateMusicTracks();
            Images = factory.CreateImages();
        }
    }
}
