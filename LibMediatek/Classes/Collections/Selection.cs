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
