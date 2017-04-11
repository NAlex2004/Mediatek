using LibMediatek.Interfaces;
using LibMediatek.Classes.Items;
using LibMediatek.Classes.Collections;
using LibMediatek.Classes.Collections.Abstract;

namespace LibMediatek.Classes.Factories
{
    /// <summary>
    /// Creates empty writable media collection
    /// (MediaLis of T)
    /// </summary>
    public class ListMediaFactory: WritableMediaFactory
    {
        public override WritableMediaCollection<MusicTrack> CreateMusicTracks()
        {
            return new MediaList<MusicTrack>();
        }

        public override WritableMediaCollection<MusicTrackReference> CreateMusicTrackReferences()
        {
            return new MediaList<MusicTrackReference>();
        }

        public override WritableMediaCollection<Photo> CreateImages()
        {
            return new MediaList<Photo>();
        }

        public override WritableMediaCollection<PhotoReference> CreateImageReferences()
        {
            return new MediaList<PhotoReference>();
        }

        public override WritableMediaCollection<Video> CreateVideos()
        {
            return new MediaList<Video>();
        }

        public override WritableMediaCollection<VideoReference> CreateVideoReferences()
        {
            return new MediaList<VideoReference>();
        }
    }
}
