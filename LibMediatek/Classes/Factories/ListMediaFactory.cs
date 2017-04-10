using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibMediatek.Interfaces;
using LibMediatek.Classes.Items;
using LibMediatek.Classes;
using LibMediatek.Classes.Collections;

namespace LibMediatek.Classes.Factories
{
    public class ListMediaFactory: MediaFactory
    {
        public override IMediaCollection<MusicTrack> CreateMusicTracks()
        {
            return new MediaList<MusicTrack>();
        }

        public override IMediaCollection<MusicTrackReference> CreateMusicTrackReferences()
        {
            return new MediaList<MusicTrackReference>();
        }

        public override IMediaCollection<Photo> CreateImages()
        {
            return new MediaList<Photo>();
        }

        public override IMediaCollection<PhotoReference> CreateImageReferences()
        {
            return new MediaList<PhotoReference>();
        }

        public override IMediaCollection<Video> CreateVideos()
        {
            return new MediaList<Video>();
        }

        public override IMediaCollection<VideoReference> CreateVideoReferences()
        {
            return new MediaList<VideoReference>();
        }
    }
}
