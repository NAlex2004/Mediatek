using System;
using LibMediatek.Interfaces;
using LibMediatek.Classes;
using System.IO;
using System.Text;

namespace LibMediatek.Classes.Items
{
    public class MusicTrack : MediaItem
    {
        protected byte[] Track;

        public MusicTrack(string title, string author, byte[] track) : base(title, author)
        {
            Track = track;
        }

        [Obsolete]
        public override bool Open()
        {
            Console.WriteLine("_____Now playing:_____");
            Console.WriteLine("Music Track: {0}\nAuthor: {1}\n", Title, Author);
            return true;
        }

        public override Stream GetContent()
        {            
            MemoryStream str = new MemoryStream();

            StreamWriter writer = new StreamWriter(str);
            writer.WriteLine("_____Now playing:_____");
            writer.WriteLine("Music Track: {0}\nAuthor: {1}\n", Title, Author);
            writer.Flush();
            str.Seek(0, SeekOrigin.Begin);
            
            // not closing writer, because we need stream

            return str;
        }
    }
}