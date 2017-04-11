using LibMediatek.Classes.Collections;
using LibMediatek.Classes.Items;
using LibMediatek.Interfaces;
using LibMediatek.Classes.Collections.Abstract;

namespace LibMediatek.Classes.Factories
{
    /// <summary>
    /// Array based fixed non-changable media disk
    /// </summary>
    public class DiskFactory : MediaFactory
    {
        private readonly MusicTrack[] _musicTracks;
        private readonly Photo[] _photoes;

        public DiskFactory(MusicTrack[] musicTracks, Photo[] photoes)
        {
            _musicTracks = musicTracks;
            _photoes = photoes;
        }

        public override MediaCollection<MusicTrack> CreateMusicTracks()
        {
            return new MediaArray<MusicTrack>(_musicTracks);
        }

        public override MediaCollection<Photo> CreateImages()
        {
            return new MediaArray<Photo>(_photoes);
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