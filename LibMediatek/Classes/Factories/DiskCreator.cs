using LibMediatek.Classes.Collections;
using LibMediatek.Classes.Items;
using LibMediatek.Interfaces;

namespace LibMediatek.Classes.Factories
{
    public class DiskCreator : DiskFactory
    {
        private IMediaRepository<MusicTrack> _musicRepo;
        private IMediaRepository<Photo> _photoRepo;

        public DiskCreator(IMediaRepository<MusicTrack> musicRepo, IMediaRepository<Photo> photoRepo)
        {
            _photoRepo = photoRepo;
            _musicRepo = musicRepo;
        }

        public override IMediaCollection<MusicTrack> CreateMusicTracks()
        {
            throw new System.NotImplementedException();
        }

        public override IMediaCollection<Photo> CreateImages()
        {
            throw new System.NotImplementedException();
        }
    }
}