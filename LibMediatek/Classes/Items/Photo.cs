using System;
using System.Drawing;
using LibMediatek.Interfaces;
using LibMediatek.Classes;
using System.IO;

namespace LibMediatek.Classes.Items
{
    public class Photo : MediaItem
    {
        protected Image _image;

//        public virtual Image Image
//        {
//            get { return _image; }
//            protected set { _image = value; }
//        }

        public Photo(string title, string author, System.Drawing.Image image) : base(title, author)
        {
            _image = image;
        }

        [Obsolete]
        public override bool Open()
        {
            Console.WriteLine("_____Photo opened:_____");
            Console.WriteLine("Photo: {0}\nAuthor: {1}\n", Title, Author);
            return true;
        }

        public override Stream GetContent()
        {
            MemoryStream str = new MemoryStream();

            StreamWriter writer = new StreamWriter(str);
            writer.WriteLine("_____Photo opened:_____");
            writer.WriteLine("Photo: {0}\nAuthor: {1}\n", Title, Author);
            writer.Flush();
            str.Seek(0, SeekOrigin.Begin);

            // not closing writer, because we need stream

            return str;
        }
    }
}