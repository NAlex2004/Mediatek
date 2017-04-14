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
    public class MediatekDemo
    {
        private IMediatek mediatek;

        public MediatekDemo(IMediatek mediatek)
        {
            this.mediatek = mediatek;
        }

        static void WriteMedia<T>(IMediaCollection<T> collection) where T: IMediaItem
        {
            Console.WriteLine("  Collection: {0}<{1}>", collection.GetType().Name, typeof(T).Name);
            foreach (var item in collection)
                Console.WriteLine(item.ToString());
            Console.WriteLine();
        }

        public void SeriesDemo()
        {
            Series series = mediatek.Series.ElementAt(0);
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
            mediatek.Player.Play(series.Videos[1].GetContent());
            //series.Videos[1].Open();

            Console.WriteLine("remove first image");
            Photo p = series.Images[0];
            series.Images.Remove(p);
            series.Images.Remove(new Photo("11", "22", null));
            WriteMedia(series.Images);            
            Console.WriteLine("===============================================");
        }

        

        public void SelectionDemo()
        {
            DiskDemo(true);
        }

        public void DiskDemo(bool changable = false)
        {
            Console.WriteLine("================== {0} ======================", (changable ? "Selection" : "  Disk "));
            Disk disk = changable ? mediatek.Disks.ElementAt(0) : mediatek.Selections.ElementAt(0);            
            WriteMedia(disk.Images);
            WriteMedia(disk.MusicTracks);
                        
            Console.WriteLine(" Try to change track..");
            disk.MusicTracks[0] = new MusicTrack("Changed Track", "Not Me", new byte[1]);

            WriteMedia(disk.MusicTracks);
            Console.WriteLine(" Open all photoes:");
            foreach (var photo in disk.Images)
            {
                mediatek.Player.Play(photo.GetContent());
            }
            Console.WriteLine("==============================================");
        }



        public void HappeningDemo()
        {
            Happening happen = mediatek.Happenings.ElementAt(0);
            Console.WriteLine("================== Happening ======================");

            WriteMedia(happen.Videos);
            WriteMedia(happen.Images);
            WriteMedia(happen.ImageReferences);
            WriteMedia(happen.VideoReferences);
            Console.WriteLine();

            Console.WriteLine("Write videos sorted by title:");

            happen.Videos.OrderBy(x => x.Title).ForEach(x => Console.WriteLine(x.ToString()));

            happen.ImageReferences.Reset();
            happen.ImageReferences.MoveNext();
            happen.ImageReferences.MoveNext();
            happen.ImageReferences.MovePrevious();
            Console.WriteLine("ImageReferences MoveNext, MoveNext, MovePrevious, Current:");
            Console.WriteLine(happen.ImageReferences.Current);

            Console.WriteLine("===============================================");

        }
    }
}
