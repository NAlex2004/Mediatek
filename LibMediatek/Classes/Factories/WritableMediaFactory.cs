using LibMediatek.Classes.Items;
using LibMediatek.Interfaces;
using LibMediatek.Classes.Collections.Abstract;

namespace LibMediatek.Classes.Factories
{
    /// <summary>
    /// abstract factory class for IWritableMediaCollection(s)
    /// </summary>
    public abstract class WritableMediaFactory
    {
            public abstract WritableMediaCollection<MusicTrack> CreateMusicTracks();
            public abstract WritableMediaCollection<MusicTrackReference> CreateMusicTrackReferences();

            public abstract WritableMediaCollection<Photo> CreateImages();
            public abstract WritableMediaCollection<PhotoReference> CreateImageReferences();

            public abstract WritableMediaCollection<Video> CreateVideos();
            public abstract WritableMediaCollection<VideoReference> CreateVideoReferences();
    }
}