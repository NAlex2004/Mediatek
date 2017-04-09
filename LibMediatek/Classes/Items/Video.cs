﻿using System;

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
            Console.WriteLine("Video: {0}\n Author: {1}\n", Title, Author);
            return true;
        }
    }
}