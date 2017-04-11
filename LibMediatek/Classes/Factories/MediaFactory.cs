﻿using LibMediatek.Classes.Items;
using LibMediatek.Interfaces;

namespace LibMediatek.Classes.Factories
{
    /// <summary>
    /// abstract factory class for IMediaCollection(s)
    /// </summary>
    public abstract class MediaFactory
    {
        public abstract IMediaCollection<MusicTrack> CreateMusicTracks();
        public abstract IMediaCollection<MusicTrackReference> CreateMusicTrackReferences();

        public abstract IMediaCollection<Photo> CreateImages();
        public abstract IMediaCollection<PhotoReference> CreateImageReferences();

        public abstract IMediaCollection<Video> CreateVideos();
        public abstract IMediaCollection<VideoReference> CreateVideoReferences();
    }
}