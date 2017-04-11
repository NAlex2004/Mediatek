using LibMediatek.Classes.Items;
using LibMediatek.Interfaces;

namespace LibMediatek.Classes.Factories
{
    /// <summary>
    /// abstract factory class for IWritableMediaCollection(s)
    /// </summary>
    public abstract class WritableMediaFactory
    {
            public abstract IWritableMediaCollection<MusicTrack> CreateMusicTracks();
            public abstract IWritableMediaCollection<MusicTrackReference> CreateMusicTrackReferences();

            public abstract IWritableMediaCollection<Photo> CreateImages();
            public abstract IWritableMediaCollection<PhotoReference> CreateImageReferences();

            public abstract IWritableMediaCollection<Video> CreateVideos();
            public abstract IWritableMediaCollection<VideoReference> CreateVideoReferences();
    }
}