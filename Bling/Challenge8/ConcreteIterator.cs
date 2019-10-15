using System.Collections.Generic;

namespace Bling.Challenge8
{
    public class ConcreteIterator<T> : IIterator<T>
    {
        private IComponent<T> aggregate;

        private List<T> collection = new List<T>();
        private int pointer = 0;

        public ConcreteIterator(IComponent<T> i)
        {
            aggregate = i;
        }

        T IIterator<T>.First()
        {
            pointer = 0;
            return collection[pointer];
        }

        T IIterator<T>.Next()
        {
            pointer++;
            return collection[pointer];
        }

        T IIterator<T>.CurrentItem()
        {
            return collection[pointer];
        }

        bool IIterator<T>.IsDone()
        {
            return pointer == (collection.Count - 1);
        }

        void IIterator<T>.AddItem(T item)
        {
            collection.Add(item);
        }
    }
}
