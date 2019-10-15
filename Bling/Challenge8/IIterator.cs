namespace Bling.Challenge8
{
    public interface IIterator<T>
    {
        T First();
        T Next();
        T CurrentItem();
        bool IsDone();
        void AddItem(T item);
    }
}
