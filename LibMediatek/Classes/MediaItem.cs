using LibMediatek.Interfaces;

namespace LibMediatek.Classes
{
	public abstract class MediaItem : IMediaItem, ISizedItem
	{
	    public string Title { get; protected set; }
	    public string Author { get; protected set; }

		public MediaItem (string title = "", string author = "")
		{
		    Title = title;
		    Author = author;
		}

	    public abstract bool Open();

	    public long Size { get; protected set; }
	}
}

