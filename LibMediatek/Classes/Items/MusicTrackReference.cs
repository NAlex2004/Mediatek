using System;
using LibMediatek.Interfaces;

namespace LibMediatek.Classes.Items
{
    public class MusicTrackReference : MusicTrack, IReferencedItem
    {
        public MusicTrackReference(string title, string author, Uri trackUri) : base(title, author, null)
        {
            Location = trackUri;
        }

        public Uri Location { get; protected set; }

        public override string ToString()
        {
            return base.ToString() + "Location Uri: " + Location + Environment.NewLine;
        }

        public override bool Open()
        {
            Console.WriteLine("Now playing:\n");
            Console.WriteLine("Music Track: {0}\nAuthor: {1}\nLocation: {2}\n", Title, Author, Location);
            return true;
        }
    }
}