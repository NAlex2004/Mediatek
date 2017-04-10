using LibMediatek.Interfaces;
using LibMediatek.Classes.Items;
using LibMediatek.Classes.Factories;

namespace LibMediatek.Classes.Collections
{
    class Happening: Series
    {
        public IWritableMediaCollection<VideoReference> VideoReferences { get; protected set; }
        public IWritableMediaCollection<PhotoReference> ImageReferences { get; protected set; }

        public Happening(MediaFactory factory) : base(factory)
        {
            VideoReferences = factory.CreateVideoReferences() as IWritableMediaCollection<VideoReference>;
            ImageReferences = factory.CreateImageReferences() as IWritableMediaCollection<PhotoReference>;
        }
    }
}
