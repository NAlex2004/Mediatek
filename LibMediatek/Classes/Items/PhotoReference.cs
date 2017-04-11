﻿using System;
using LibMediatek.Interfaces;
using LibMediatek.Classes;

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

        public override bool Open()
        {
            Console.WriteLine("_____Photo opened:_____");
            Console.WriteLine("Photo: {0}\nAuthor: {1}\nLocation: {2}\n", Title, Author, Location);
            return true;
        }
    }
}