using System;

namespace LibMediatek.Interfaces
{
	public interface IMediaItem
	{
	    int? Id { get; }
		string Title { get; }
		string Author { get; }
	    bool Open();
	}
}

