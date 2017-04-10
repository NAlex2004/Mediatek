using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibMediatek.Interfaces;
using LibMediatek.Classes;
using LibMediatek.Classes.Collections;
using LibMediatek.Classes.Items;
using LibMediatek.Classes.Factories;

namespace LibMediatek.Classes.Collections
{
    /// <summary>
    /// Disk in which items are allowed to be replaced or changed, if created with SelectionFactory
    /// If using DiskFactory it will be just Disk.
    /// </summary>
    public class Selection: Disk
    {
        public Selection(MediaFactory factory): base(factory) {}
    }
}
