using System;
using LibMediatek.Interfaces;
using LibMediatek.Classes;

namespace LibMediatek.Classes.Items
{
    public class MusicTrack : MediaItem
    {
        protected byte[] _track;

        public MusicTrack(string title, string author, byte[] track) : base(title, author)
        {
            _track = track;
        }

        public override bool Open()
        {
            Console.WriteLine("Music Track: {0}\n Author: {1}\n", Title, Author);
            return true;
        }
    }
}