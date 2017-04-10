using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibMediatek.Interfaces;
using LibMediatek.Classes.Items;
using LibMediatek.Classes.Collections;
using LibMediatek.Classes.Factories;

using Selection = LibMediatek.Classes.Collections.Disk;

namespace MediatekDemo
{
    class Program
    {
        static void SeriesDemo()
        {
            ListMediaFactory sFact = new ListMediaFactory();
            Series series = new Series(sFact);
            series.Videos.Add(new Video("Video 1", "operator", new byte[1]));
            series.Videos[0] = new Video("Video 2", "No operator", new byte[1]);
            Console.WriteLine(series.Videos[0].ToString());
        }

        static void DiskAndSelectionDemo()
        {
            MusicTrack[] tracks = new MusicTrack[] 
            {
                new MusicTrack("Track 1", "Noone", new byte[1]),
                new MusicTrack("Track 2", "Noone", new byte[1]),
                new MusicTrack("Track 3", "Noone", new byte[1])
            };

            Photo[] photoes = new Photo[]
            {
                new Photo("Photo 1", "Some author", new System.Drawing.Bitmap(1, 1)),
                new Photo("Photo 1", "Some author", new System.Drawing.Bitmap(1, 1)),
                new PhotoReference("Photo 1", "Some author", new Uri("file:///nothing.bmp"))
            };

            DiskFactory dFact = new DiskFactory(tracks, photoes);
            Disk disk = new Disk(dFact);

            SelectionFactory sFact = new SelectionFactory(tracks, photoes);
            Selection selection = new Selection(sFact);

            disk.MusicTracks[0] = new MusicTrack("New Disk Track", "Not Me", new byte[1]);
            selection.MusicTracks[0] = new MusicTrack("New Track", "Me", new byte[1]);

            foreach (var track in selection.MusicTracks)
            {
                track.Open();
            }

            foreach (var photo in disk.Images)
            {
                photo.Open();
                PhotoReference pr = photo as PhotoReference;
                if (pr != null)
                    Console.WriteLine("Item is reference to photo. Uri is: {0}", pr.Location);
            }
        }

        static void Main(string[] args)
        {
            SeriesDemo();
            DiskAndSelectionDemo();            

            Console.ReadKey();
        }
    }
}
