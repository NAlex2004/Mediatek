using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibMediatek.Interfaces;
using System.IO;

namespace LibMediatek.Classes
{
    class SimpleMediaPlayer : IMediaPlayer
    {
        public void Play(Stream stream)
        {
            // in case stream position is not in beginning
            stream.Seek(0, SeekOrigin.Begin);
            StreamReader reader = new StreamReader(stream);
            Console.WriteLine(reader.ReadToEnd());
        }
    }
}
