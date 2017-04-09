using System;
using System.Drawing;
using LibMediatek.Interfaces;
using LibMediatek.Classes;

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

        public override bool Open()
        {
            Console.WriteLine("Photo: {0}\n Author: {1}\n", Title, Author);
            return true;
        }
    }
}