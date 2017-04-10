using LibMediatek.Interfaces;
using LibMediatek.Classes.Items;
using LibMediatek.Classes.Collections;

namespace LibMediatek.Classes.Factories
{
    public class ListMediaFactory: WritableMediaFactory
    {
        public override IWritableMediaCollection<MusicTrack> CreateMusicTracks()
        {
            return new MediaList<MusicTrack>();
        }

        public override IWritableMediaCollection<MusicTrackReference> CreateMusicTrackReferences()
        {
            return new MediaList<MusicTrackReference>();
        }

        public override IWritableMediaCollection<Photo> CreateImages()
        {
            return new MediaList<Photo>();
        }

        public override IWritableMediaCollection<PhotoReference> CreateImageReferences()
        {
            return new MediaList<PhotoReference>();
        }

        public override IWritableMediaCollection<Video> CreateVideos()
        {
            return new MediaList<Video>();
        }

        public override IWritableMediaCollection<VideoReference> CreateVideoReferences()
        {
            return new MediaList<VideoReference>();
        }
    }
}
