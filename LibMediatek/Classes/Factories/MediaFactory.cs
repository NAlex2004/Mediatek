using LibMediatek.Classes.Items;
using LibMediatek.Interfaces;
using LibMediatek.Classes.Collections.Abstract;

namespace LibMediatek.Classes.Factories
{
    /// <summary>
    /// abstract factory class for IMediaCollection(s)
    /// </summary>
    public abstract class MediaFactory
    {
        public abstract MediaCollection<MusicTrack> CreateMusicTracks();
        public abstract MediaCollection<MusicTrackReference> CreateMusicTrackReferences();

        public abstract MediaCollection<Photo> CreateImages();
        public abstract MediaCollection<PhotoReference> CreateImageReferences();

        public abstract MediaCollection<Video> CreateVideos();
        public abstract MediaCollection<VideoReference> CreateVideoReferences();
    }
}