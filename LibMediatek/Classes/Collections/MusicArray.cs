using LibMediatek.Classes.Items;
using LibMediatek.Classes.Repositories;
using LibMediatek.Interfaces;

namespace LibMediatek.Classes.Collections
{
    public class MusicArray: MediaCollection<MusicTrack>
    {
        public MusicArray(MusicTrack[] tracks)
        {
            Repository = new ArrayRepository<MusicTrack>(tracks);
        }
    }
}