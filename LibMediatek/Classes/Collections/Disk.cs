using LibMediatek.Classes.Factories;
using LibMediatek.Classes.Items;
using LibMediatek.Interfaces;

namespace LibMediatek.Classes.Collections
{
    /// <summary>
    /// Disk or Selection (created by factory).
    /// Disk items cannot be changed.
    /// </summary>
    public class Disk
    {
        public IMediaCollection<MusicTrack> MusicTracks { get; protected set; }
        public IMediaCollection<Photo> Images { get; protected set; }

        public Disk(MediaFactory factory)
        {
            MusicTracks = factory.CreateMusicTracks();
            Images = factory.CreateImages();
        }
    }
}