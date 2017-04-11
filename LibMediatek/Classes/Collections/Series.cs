using LibMediatek.Interfaces;
using LibMediatek.Classes.Items;
using LibMediatek.Classes.Factories;
using LibMediatek.Classes.Collections.Abstract;

namespace LibMediatek.Classes.Collections
{
    /// <summary>
    /// writable series 'collection'
    /// </summary>
    public class Series
    {
        public WritableMediaCollection<Video> Videos { get; protected set; }
        public WritableMediaCollection<Photo> Images { get; protected set; }

        public Series(WritableMediaFactory factory)
        {
            Videos = factory.CreateVideos();
            Images = factory.CreateImages();
        }
    }
}
