using System;

namespace LibMediatek.Classes.Items
{
    public class Video : MediaItem
    {
        protected byte[] VideoTrack;

        public Video(string title, string author, byte[] videoTrack) : base(title, author)
        {
            VideoTrack = videoTrack;
        }

        public override bool Open()
        {
            Console.WriteLine("_____Now playing:_____");
            Console.WriteLine("Video: {0}\nAuthor: {1}\n", Title, Author);
            return true;
        }
    }
}