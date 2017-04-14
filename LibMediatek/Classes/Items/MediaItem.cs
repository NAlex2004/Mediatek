using System.IO;
using LibMediatek.Interfaces;
using System.Text;

namespace LibMediatek.Classes.Items
{
    public abstract class MediaItem : IMediaItem, ISizedItem
    {
        public int? Id { get; protected set; }
        public string Title { get; protected set; }
        public string Author { get; protected set; }

        public MediaItem (string title, string author)
        {
            Title = title;
            Author = author;
            Id = null;
        }

        public abstract bool Open();

        public override string ToString()
        {
            return string.Format("Title: {0}\nAuthor: {1}\n", Title, Author);
        }

        public override bool Equals(object obj)
        {
            MediaItem item = obj as MediaItem;
            if (item != null)
            {
                return (Title == item.Title && Author == item.Author && Id == item.Id);
            }

            return false;
        }

        public long Size { get; protected set; }


        public abstract Stream GetContent();
        
    }
}

