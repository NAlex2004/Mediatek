using LibMediatek.Interfaces;
using LibMediatek.Classes.Items;
using LibMediatek.Classes.Factories;
using LibMediatek.Classes.Collections.Abstract;

namespace LibMediatek.Classes.Collections
{
    /// <summary>
    /// changable, writable, images, videos and references
    /// </summary>
    public class Happening: Series
    {
        public WritableMediaCollection<VideoReference> VideoReferences { get; protected set; }
        public WritableMediaCollection<PhotoReference> ImageReferences { get; protected set; }

        public Happening(WritableMediaFactory factory) : base(factory)
        {
            VideoReferences = factory.CreateVideoReferences();
            ImageReferences = factory.CreateImageReferences();
        }
    }
}
