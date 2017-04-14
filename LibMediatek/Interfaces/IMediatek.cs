using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibMediatek.Interfaces;
using LibMediatek.Classes;
using LibMediatek.Classes.Items;
using LibMediatek.Classes.Collections;

namespace LibMediatek.Interfaces
{
    public interface IMediatek
    {
        ICollection<Photo> Photoes { get; }
        ICollection<PhotoReference> PhotoReferencies { get; }
        ICollection<Video> Videos { get; }
        ICollection<VideoReference> VideoReferencies { get; }
        ICollection<MusicTrack> MusicTracks { get; }
        ICollection<MusicTrackReference> MusicTrackReferencies { get; }
        ICollection<Happening> Happenings { get; }
        ICollection<Disk> Disks { get; }
        ICollection<Series> Series { get; }
        ICollection<Selection> Selections { get; }

        IMediaPlayer Player { get; }
    }
}
