using System;
using LibMediatek.Interfaces;
using LibMediatek.Classes;
using System.IO;

namespace LibMediatek.Classes.Items
{
    public class PhotoReference : Photo, IReferencedItem
    {
        public PhotoReference(string title, string author, Uri imageUri) : base(title, author, null)
        {
            Location = imageUri;
        }

        public Uri Location { get; protected set; }

        public override string ToString()
        {
            return base.ToString() + "Location Uri: " + Location + Environment.NewLine;
        }

        [Obsolete]
        public override bool Open()
        {
            Console.WriteLine("_____Photo opened:_____");
            Console.WriteLine("Photo: {0}\nAuthor: {1}\nLocation: {2}\n", Title, Author, Location);
            return true;
        }

        public override Stream GetContent()
        {
            MemoryStream str = new MemoryStream();

            StreamWriter writer = new StreamWriter(str);
            writer.WriteLine("_____Photo opened:_____");
            writer.WriteLine("Photo: {0}\nAuthor: {1}\nLocation: {2}\n", Title, Author, Location);
            writer.Flush();
            str.Seek(0, SeekOrigin.Begin);

            // not closing writer, because we need stream

            return str;
        }
    }
}