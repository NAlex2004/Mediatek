using System;
using LibMediatek.Interfaces;

namespace LibMediatek.Classes.Items
{
    public class VideoReference : Video, IReferencedItem
    {
        public VideoReference(string title, string author, Uri videoUri) : base(title, author, null)
        {
            Location = videoUri;
        }

        public Uri Location { get; protected set; }

        public override bool Open()
        {
            Console.WriteLine("Video: {0}\nAuthor: {1}\nLocation: {2}\n", Title, Author, Location);
            return true;
        }
    }
}