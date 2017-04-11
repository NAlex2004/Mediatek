using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibMediatek.Classes;
using LibMediatek.Interfaces;
using LibMediatek.Classes.Items;
using LibMediatek.Classes.Collections;
using LibMediatek.Classes.Collections.Abstract;

namespace LibMediatek.Classes.Factories
{
    /// <summary>
    /// Like DiskFactory, array-based, but items can be changed by this[index]
    /// </summary>
    public class SelectionFactory: MediaFactory
    {
        private readonly MusicTrack[] _musicTracks;
        private readonly Photo[] _photoes;

        public SelectionFactory(MusicTrack[] musicTracks, Photo[] photoes)
        {
            _musicTracks = musicTracks;
            _photoes = photoes;
        }

        public override MediaCollection<MusicTrack> CreateMusicTracks()
        {
            return new UpdatableMediaArray<MusicTrack>(_musicTracks);
        }

        public override MediaCollection<Photo> CreateImages()
        {
            return new UpdatableMediaArray<Photo>(_photoes);
        }

        public override MediaCollection<MusicTrackReference> CreateMusicTrackReferences()
        {
            return null;
        }

        public override MediaCollection<PhotoReference> CreateImageReferences()
        {
            return null;
        }

        public override MediaCollection<Video> CreateVideos()
        {
            return null;
        }

        public override MediaCollection<VideoReference> CreateVideoReferences()
        {
            return null;
        }
    }
}
