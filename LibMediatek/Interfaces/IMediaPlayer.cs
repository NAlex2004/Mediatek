using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LibMediatek.Interfaces
{
    public interface IMediaPlayer
    {
        void Play(Stream stream);
    }
}
