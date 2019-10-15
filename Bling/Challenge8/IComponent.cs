using System.Collections.Generic;

namespace Bling.Challenge8
{
    public interface IComponent<T>
    {
        IIterator<T> CreateIterator();

        List<T> GetElements();

        void AddElement(T element);
    }
}