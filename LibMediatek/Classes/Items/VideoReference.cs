﻿using System;
using LibMediatek.Interfaces;

namespace LibMediatek.Classes.Items
{
    public class VideoReference : Video, IReferencedItem
    {
        public VideoReference(string title, string author, Uri videoUri) : base(title, author, null)
        {
            Location = videoUri;
        }

        public Uri Location { get; }

        public override bool Open()
        {
            Console.WriteLine("Video: {0}\n Author: {1}\n, Location: {2}", Title, Author, Location);
            return true;
        }
    }
}