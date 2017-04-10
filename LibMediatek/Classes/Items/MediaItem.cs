using LibMediatek.Interfaces;

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
			return string.Format("Title: {0}\nAuthor: {1}\n");
		}

		public long Size { get; protected set; }
	}
}

