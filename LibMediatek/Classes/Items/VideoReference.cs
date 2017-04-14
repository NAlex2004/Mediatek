using System;
using LibMediatek.Interfaces;
using System.IO;

namespace LibMediatek.Classes.Items
{
    public class VideoReference : Video, IReferencedItem
    {
        public VideoReference(string title, string author, Uri videoUri) : base(title, author, null)
        {
            Location = videoUri;
        }

        public Uri Location { get; protected set; }

        public override string ToString()
        {
            return base.ToString() + "Location Uri: " + Location + Environment.NewLine;
        }

        [Obsolete]
        public override bool Open()
        {
            Console.WriteLine("_____Now playing:_____");
            Console.WriteLine("Video: {0}\nAuthor: {1}\nLocation: {2}\n", Title, Author, Location);
            return true;
        }

        public override Stream GetContent()
        {
            MemoryStream str = new MemoryStream();

            StreamWriter writer = new StreamWriter(str);
            writer.WriteLine("_____Now playing:_____");
            writer.WriteLine("Video: {0}\nAuthor: {1}\nLocation: {2}\n", Title, Author, Location);
            writer.Flush();
            str.Seek(0, SeekOrigin.Begin);

            // not closing writer, because we need stream

            return str;
        }
    }
}