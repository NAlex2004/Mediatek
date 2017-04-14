using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibMediatek.Interfaces;
using LibMediatek.Classes;
using LibMediatek.Classes.Items;
using LibMediatek.Classes.Collections;
using LibMediatek.Classes.Factories;

namespace LibMediatek.Classes.Collections
{
    public class SimpleMediatek: IMediatek
    {
        public SimpleMediatek(MediatekFactory factory)
        {
            Photoes = factory.CreatePhotoes();
            PhotoReferencies = factory.CreatePhotoReferencies();
            Videos = factory.CreateVideos();
            VideoReferencies = factory.CreateVideoReferencies();
            MusicTracks = factory.CreateMusicTracks();
            MusicTrackReferencies = factory.CreateMusicTrackReferencies();
            Disks = factory.CreateDisks();
            Happenings = factory.CreateHappenings();
            Series = factory.CreateSeries();
            Selections = factory.CreateSelections();
            Player = factory.CreatePlayer();
        }

        public ICollection<Photo> Photoes
        {
            get;
            private set;
        }

        public ICollection<PhotoReference> PhotoReferencies
        {
            get;
            private set;
        }

        public ICollection<Video> Videos
        {
            get;
            private set;
        }

        public ICollection<VideoReference> VideoReferencies
        {
            get;
            private set;
        }

        public ICollection<MusicTrack> MusicTracks
        {
            get;
            private set;
        }

        public ICollection<MusicTrackReference> MusicTrackReferencies
        {
            get;
            private set;
        }

        public ICollection<Happening> Happenings
        {
            get;
            private set;
        }

        public ICollection<Disk> Disks
        {
            get;
            private set;
        }

        public ICollection<Series> Series
        {
            get;
            private set;
        }

        public ICollection<Selection> Selections
        {
            get;
            private set;
        }

        public IMediaPlayer Player
        {
            get;
            private set;
        }
    }
}
