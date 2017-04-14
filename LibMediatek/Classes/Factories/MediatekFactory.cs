using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibMediatek.Interfaces;
using LibMediatek.Classes;
using LibMediatek.Classes.Items;
using LibMediatek.Classes.Collections;

namespace LibMediatek.Classes.Factories
{
    public abstract class MediatekFactory
    {
        public abstract ICollection<Photo> CreatePhotoes();
        public abstract ICollection<PhotoReference> CreatePhotoReferencies();
        public abstract ICollection<Video> CreateVideos();
        public abstract ICollection<VideoReference> CreateVideoReferencies();
        public abstract ICollection<MusicTrack> CreateMusicTracks();
        public abstract ICollection<MusicTrackReference> CreateMusicTrackReferencies();
        public abstract ICollection<Happening> CreateHappenings();
        public abstract ICollection<Disk> CreateDisks();
        public abstract ICollection<Series> CreateSeries();
        public abstract ICollection<Selection> CreateSelections();
        public abstract IMediaPlayer CreatePlayer();
    }
}
