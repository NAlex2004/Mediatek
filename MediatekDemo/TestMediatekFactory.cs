using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibMediatek.Interfaces;
using LibMediatek.Classes.Items;
using LibMediatek.Classes.Collections;
using LibMediatek.Classes.Factories;
using LibMediatek.Classes.Collections.Abstract;
using LibMediatek.Classes;

namespace MediatekDemo
{
    /// <summary>
    /// Create and initialize demo mediatek
    /// </summary>
    public class TestMediatekFactory: MediatekFactory
    {
        public override ICollection<Photo> CreatePhotoes()
        {
            return new List<Photo>()
            {
                new Photo("Empty picture", "Bare Eye", new System.Drawing.Bitmap(1, 1)),
                new Photo("Some Photo", "google", new System.Drawing.Bitmap(1, 1))
            };                        
        }

        public override ICollection<PhotoReference> CreatePhotoReferencies()
        {
            return new List<PhotoReference>()
            {
                new PhotoReference("Empty reference", "google", new Uri("https://nothing.com/empty.jpg")),
                new PhotoReference("Some reference", "google", new Uri("https://vignette3.wikia.nocookie.net/uncyclopedia/images/b/b7/Press_any_key.jpg"))
            };         
        }

        public override ICollection<Video> CreateVideos()
        {
            return new List<Video>()
            {
                new Video("Video #1", "Noname", new byte[1]),
                new Video("Video #3", "Test", new byte[1]),
                new Video("Video #2", "Name", new byte[1]),
                new Video("Video #4", "Demo", new byte[1])
            };
        }

        public override ICollection<VideoReference> CreateVideoReferencies()
        {
            return new List<VideoReference>()
            {
                new VideoReference("Video Ref #1", "Ref", new Uri("file://file.avi")),
                new VideoReference("Video Ref #2", "Reffff", new Uri("file://file2.avi"))
            };
        }

        public override ICollection<MusicTrack> CreateMusicTracks()
        {
            return new List<MusicTrack>()
            {
                new MusicTrack("Music Track 1", "Noone", new byte[1]),
                new MusicTrack("Music Track 2", "Someone", new byte[1]),
                new MusicTrack("Music Track 3", "Noone", new byte[1])
            };
        }

        public override ICollection<MusicTrackReference> CreateMusicTrackReferencies()
        {
            return new List<MusicTrackReference>()
            {
                new MusicTrackReference("Music Ref 1", "Noone", new Uri("file://music1.mp3")),
                new MusicTrackReference("Music Ref 2", "Someone", new Uri("http://music.mus.com/music2.mp3")),
                new MusicTrackReference("Music Ref 3", "Noone", new Uri("file://music3.mp3"))
            };
        }

        public override ICollection<Happening> CreateHappenings()
        {
            return new List<Happening>()
            {
                ConstructHappening()
            };
        }

        public override ICollection<Disk> CreateDisks()
        {
            return new List<Disk>()
            {
                new Disk(CreateDiskFactory(false))
            };
        }

        public override ICollection<Series> CreateSeries()
        {
            return new List<Series>()
            {
                ConstructSeries()
            };
        }

        public override ICollection<Selection> CreateSelections()
        {
            return new List<Selection>()
            {
                new Selection(CreateDiskFactory(true))
            };
        }

        public override IMediaPlayer CreatePlayer()
        {
            return new SimpleMediaPlayer();
        }

        // -----------------------------------

        static void AddVideo(IWritableMediaCollection<Video> collection)
        {
            collection.Add(new Video("Video #1", "Noname", new byte[1]));
            collection.Add(new Video("Video #3", "Noname", new byte[1]));
            collection.Add(new Video("Video #2", "Unknown", new byte[1]));
            collection.Add(new Video("Video #4", "Unknown", new byte[1]));
        }

        static void AddImages(IWritableMediaCollection<Photo> collection)
        {
            collection.Add(new Photo("Empty picture", "Bare Eye", new System.Drawing.Bitmap(1, 1)));
            collection.Add(new Photo("Some Photo", "google", new System.Drawing.Bitmap(1, 1)));
        }

        static void AddVideoReferences(IWritableMediaCollection<VideoReference> collection)
        {
            collection.Add(new VideoReference("Video Ref #1", "Ref", new Uri("file://file.avi")));
            collection.Add(new VideoReference("Video Ref #2", "Ref", new Uri("file://file2.avi")));
        }

        static void AddImageReferences(IWritableMediaCollection<PhotoReference> collection)
        {
            collection.Add(new PhotoReference("Empty reference", "google", new Uri("https://nothing.com/empty.jpg")));
            collection.Add(new PhotoReference("Some reference", "google", new Uri("https://vignette3.wikia.nocookie.net/uncyclopedia/images/b/b7/Press_any_key.jpg")));
        }

        static Series ConstructSeries()
        {
            ListMediaFactory sFact = new ListMediaFactory();
            Series series = new Series(sFact);
            AddVideo(series.Videos);
            AddImages(series.Images);
            AddImageReferences(series.Images);
            return series;
        }

        static Happening ConstructHappening()
        {
            ListMediaFactory sFact = new ListMediaFactory();
            Happening happen = new Happening(sFact);
            AddVideo(happen.Videos);
            AddVideoReferences(happen.VideoReferences);
            AddImages(happen.Images);
            AddImageReferences(happen.ImageReferences);
            return happen;
        }

        static MediaFactory CreateDiskFactory(bool changable = false)
        {
            MusicTrack[] tracks = new MusicTrack[] 
            {
                new MusicTrack("Music Track 1", "Noone", new byte[1]),
                new MusicTrack("Music Track 2", "Someone", new byte[1]),
                new MusicTrack("Music Track 3", "Noone", new byte[1])
            };

            Photo[] photoes = new Photo[]
            {
                new Photo("Photo 1", "Some author", new System.Drawing.Bitmap(1, 1)),
                new Photo("Photo 2", "No author", new System.Drawing.Bitmap(1, 1)),
                new PhotoReference("Photo 3", "Some author", new Uri("file:///nothing.bmp"))
            };

            MediaFactory factory;
            if (changable)
                factory = new SelectionFactory(tracks, photoes);
            else
                factory = new DiskFactory(tracks, photoes);
            return factory;
        }
    }
}
