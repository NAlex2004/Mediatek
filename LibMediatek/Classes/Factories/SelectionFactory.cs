using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibMediatek.Classes;
using LibMediatek.Interfaces;
using LibMediatek.Classes.Items;
using LibMediatek.Classes.Collections;

namespace LibMediatek.Classes.Factories
{
    class SelectionFactory: MediaFactory
    {
        private readonly MusicTrack[] _musicTracks;
        private readonly Photo[] _photoes;

        public SelectionFactory(MusicTrack[] musicTracks, Photo[] photoes)
        {
            _musicTracks = musicTracks;
            _photoes = photoes;
        }

        public override IMediaCollection<MusicTrack> CreateMusicTracks()
        {
            return new UpdatableMediaArray<MusicTrack>(_musicTracks);
        }

        public override IMediaCollection<Photo> CreateImages()
        {
            return new UpdatableMediaArray<Photo>(_photoes);
        }

        public override IMediaCollection<MusicTrackReference> CreateMusicTrackReferences()
        {
            return null;
        }

        public override IMediaCollection<PhotoReference> CreateImageReferences()
        {
            return null;
        }

        public override IMediaCollection<Video> CreateVideos()
        {
            return null;
        }

        public override IMediaCollection<VideoReference> CreateVideoReferences()
        {
            return null;
        }
    }
}
