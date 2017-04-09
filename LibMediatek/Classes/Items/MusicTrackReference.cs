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

        public Uri Location { get; }

        public override bool Open()
        {
            Console.WriteLine("Music Track: {0}\n Author: {1}\n, Location: {2}", Title, Author, Location);
            return true;
        }
    }
}