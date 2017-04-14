using System;
using System.IO;

namespace LibMediatek.Interfaces
{
	public interface IMediaItem
	{
		int? Id { get; }
		string Title { get; }
		string Author { get; }
		[Obsolete]
		bool Open();
		Stream GetContent();
	}
}

