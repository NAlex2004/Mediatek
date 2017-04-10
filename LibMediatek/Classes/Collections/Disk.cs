using LibMediatek.Classes.Factories;
using LibMediatek.Classes.Items;
using LibMediatek.Interfaces;

namespace LibMediatek.Classes.Collections
{
    public class Disk
    {
        private IMediaCollection<MusicTrack> _tracks;
        private IMediaCollection<Photo> _images;

        public IMediaCollection<MusicTrack> MusicTracks
        {
            get { return _tracks; }
        }

        public IMediaCollection<Photo> Images
        {
            get { return _images; }
        }

        public Disk(MediaFactory factory)
        {
            _tracks = factory.CreateMusicTracks();
            _images = factory.CreateImages();
        }
    }
}