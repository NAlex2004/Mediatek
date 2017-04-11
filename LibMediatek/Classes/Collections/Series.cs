using LibMediatek.Interfaces;
using LibMediatek.Classes.Items;
using LibMediatek.Classes.Factories;

namespace LibMediatek.Classes.Collections
{
    /// <summary>
    /// writable series 'collection'
    /// </summary>
    public class Series
    {
        public IWritableMediaCollection<Video> Videos { get; protected set; }
        public IWritableMediaCollection<Photo> Images { get; protected set; }

        public Series(WritableMediaFactory factory)
        {
            Videos = factory.CreateVideos();
            Images = factory.CreateImages();
        }
    }
}
