using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibMediatek.Interfaces;
using LibMediatek.Classes.Items;
using LibMediatek.Classes.Collections;
using LibMediatek.Classes.Factories;
using LibMediatek.Classes.Collections.Abstract;

namespace MediatekDemo
{
    public static class MediatekDemo
    {
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
            collection.Add(new PhotoReference("Empty reference", "google", new Uri("https://nothing.com/empty.jpg")));
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

        static Series CreateSeries()
        {
            ListMediaFactory sFact = new ListMediaFactory();
            Series series = new Series(sFact);
            AddVideo(series.Videos);
            AddImages(series.Images);
            return series;
        }

        static Happening CreateHappening()
        {
            ListMediaFactory sFact = new ListMediaFactory();
            Happening happen = new Happening(sFact);
            AddVideo(happen.Videos);
            AddVideoReferences(happen.VideoReferences);
            AddImages(happen.Images);
            AddImageReferences(happen.ImageReferences);
            return happen;
        }

        static void WriteMedia<T>(IMediaCollection<T> collection) where T: IMediaItem
        {
            Console.WriteLine("  Collection: {0}<{1}>", collection.GetType().Name, typeof(T));
            foreach (var item in collection)
                Console.WriteLine(item.ToString());
            Console.WriteLine();
        }

        public static void SeriesDemo()
        {
            Series series = CreateSeries();
            Console.WriteLine("================== Series ======================");
            
            WriteMedia(series.Videos);
            WriteMedia(series.Images);
            Console.WriteLine();
            
            Console.WriteLine("Video:  Add item, change item, replace item..");
            series.Videos.Add(new Video("New Video", "operator", new byte[1]));
            series.Videos[0] = new Video("Changed Video", "No operator", new byte[1]);
            Video vid = series.Videos[1];            
            series.Videos.Replace(vid, new Video("Video Replaced", "John Jack", new byte[1]));
            Console.WriteLine("  Result:");
            WriteMedia(series.Videos);
            Console.WriteLine("__Open Video[1]: ");
            series.Videos[1].Open();

            Console.WriteLine("remove first image");
            Photo p = series.Images[0];
            series.Images.Remove(p);
            series.Images.Remove(new Photo("11", "22", null));
            WriteMedia(series.Images);            
            Console.WriteLine("===============================================");
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

        public static void SelectionDemo()
        {
            DiskDemo(true);
        }

        public static void DiskDemo(bool changable = false)
        {
            Console.WriteLine("================== {0} ======================", (changable ? "Selection" : "  Disk "));
            Disk disk = new Disk(CreateDiskFactory(changable));
            WriteMedia(disk.Images);
            WriteMedia(disk.MusicTracks);
                        
            Console.WriteLine(" Try to change track..");
            disk.MusicTracks[0] = new MusicTrack("Changed Track", "Not Me", new byte[1]);

            WriteMedia(disk.MusicTracks);
            Console.WriteLine(" Open all photoes:");
            foreach (var photo in disk.Images)
            {
                photo.Open();                
            }
            Console.WriteLine("==============================================");
        }



        public static void HappeningDemo()
        {
            Happening happen = CreateHappening();
            
            Console.WriteLine("================== Series ======================");

            WriteMedia(happen.Videos);
            WriteMedia(happen.Images);
            WriteMedia(happen.ImageReferences);
            WriteMedia(happen.VideoReferences);
            Console.WriteLine();

            Console.WriteLine("Write videos sorted by title:");

            happen.Videos.OrderBy(x => x.Title).ForEach(x => Console.WriteLine(x.ToString()));
            
            Console.WriteLine("===============================================");
        }
    }
}
