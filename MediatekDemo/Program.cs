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
        
        static void AnyKey()
        {
            Console.Write("Any key to continue..");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //MediatekDemo.DiskDemo();
            //AnyKey();
            //MediatekDemo.SelectionDemo();
            //AnyKey();
            MediatekDemo.SeriesDemo();
            AnyKey();
            MediatekDemo.HappeningDemo();
            Console.ReadKey();
        }
    }
}
