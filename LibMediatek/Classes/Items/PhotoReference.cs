using System;
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

        public override bool Open()
        {
            Console.WriteLine("Photo: {0}\n Author: {1}\n Location: {2}\n", Title, Author, Location);
            return true;
        }
    }
}