using System.Linq;
using LibMediatek.Interfaces;

namespace LibMediatek.Classes
{
    public abstract class MediaCollection
    {
        protected IMediaRepository Repository;
//        IMediaItem this[int index] { get; }
//        IMediaItem this[string title] { get; }

        /// <summary>
        /// Get and set item by ID
        /// </summary>
        /// <param name="id"></param>
        public IMediaItem this[int? id]
        {
            get
            {

            }

            set
            {

            }
        }

        public IMediaItem this[string title]
        {
            get
            {
                var items = Repository.Find(x => x.Title.Equals(title));
                if (items != null)
                    return items.FirstOrDefault();
                return null;
            }
        }
    }
}