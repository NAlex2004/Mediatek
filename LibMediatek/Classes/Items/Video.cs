using System;
using System.IO;

namespace LibMediatek.Classes.Items
{
    public class Video : MediaItem
    {
        protected byte[] VideoTrack;

        public Video(string title, string author, byte[] videoTrack) : base(title, author)
        {
            VideoTrack = videoTrack;
        }

        [Obsolete]
        public override bool Open()
        {
            Console.WriteLine("_____Now playing:_____");
            Console.WriteLine("Video: {0}\nAuthor: {1}\n", Title, Author);
            return true;
        }

        public override Stream GetContent()
        {
            MemoryStream str = new MemoryStream();

            StreamWriter writer = new StreamWriter(str);
            writer.WriteLine("_____Now playing:_____");
            writer.WriteLine("Video: {0}\nAuthor: {1}\n", Title, Author);
            writer.Flush();
            str.Seek(0, SeekOrigin.Begin);

            // not closing writer, because we need stream

            return str;
        }
    }
}