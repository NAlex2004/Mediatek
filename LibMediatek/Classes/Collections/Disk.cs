using LibMediatek.Classes.Factories;
using LibMediatek.Classes.Items;
using LibMediatek.Interfaces;
using LibMediatek.Classes.Collections.Abstract;

namespace LibMediatek.Classes.Collections
{
    /// <summary>
    /// Disk or Selection (created by factory).
    /// Disk items cannot be changed.
    /// </summary>
    public class Disk
    {
        public MediaCollection<MusicTrack> MusicTracks { get; protected set; }
        public MediaCollection<Photo> Images { get; protected set; }

        public Disk(MediaFactory factory)
        {
            MusicTracks = factory.CreateMusicTracks();
            Images = factory.CreateImages();
        }
    }
}