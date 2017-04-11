using LibMediatek.Classes.Collections;
using LibMediatek.Classes.Items;
using LibMediatek.Interfaces;

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

        public override IMediaCollection<MusicTrack> CreateMusicTracks()
        {
            return new MediaArray<MusicTrack>(_musicTracks);
        }

        public override IMediaCollection<Photo> CreateImages()
        {
            return new MediaArray<Photo>(_photoes);
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