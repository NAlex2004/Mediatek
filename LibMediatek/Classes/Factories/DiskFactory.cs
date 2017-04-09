using LibMediatek.Classes.Items;
using LibMediatek.Interfaces;

namespace LibMediatek.Classes.Factories
{
    public abstract class DiskFactory
    {
        public abstract IMediaCollection<MusicTrack> CreateMusicTracks();
        public abstract IMediaCollection<Photo> CreateImages();
    }
}