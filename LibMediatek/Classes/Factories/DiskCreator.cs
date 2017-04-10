using LibMediatek.Classes.Collections;
using LibMediatek.Classes.Items;
using LibMediatek.Interfaces;

namespace LibMediatek.Classes.Factories
{
    public class DiskCreator : DiskFactory
    {
        private readonly MusicTrack[] _musicTracks;
        private readonly Photo[] _photoes;

        public DiskCreator(MusicTrack[] musicTracks, Photo[] photoes)
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
            throw new System.NotImplementedException();
        }
    }
}