namespace LibMediatek.Interfaces
{
    public interface IWritableMediaCollection<T>: IMediaCollection<T> where T: IMediaItem
    {
        void Add(T item);
        bool Remove(T item);
        bool Replace(T oldItem, T newItem);
        void Clear();
    }
}