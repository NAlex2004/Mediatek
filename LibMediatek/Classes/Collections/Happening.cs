using LibMediatek.Interfaces;
using LibMediatek.Classes.Items;
using LibMediatek.Classes.Factories;

namespace LibMediatek.Classes.Collections
{
    /// <summary>
    /// changable, writable, images, videos and references
    /// </summary>
    class Happening: Series
    {
        public IWritableMediaCollection<VideoReference> VideoReferences { get; protected set; }
        public IWritableMediaCollection<PhotoReference> ImageReferences { get; protected set; }

        public Happening(WritableMediaFactory factory) : base(factory)
        {
            VideoReferences = factory.CreateVideoReferences();
            ImageReferences = factory.CreateImageReferences();
        }
    }
}
