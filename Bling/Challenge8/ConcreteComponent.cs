using System.Collections.Generic;

namespace Bling.Challenge8
{
    public class ConcreteComponent<T> : IComponent<T>
    {
        private IIterator<T> iterator;

        public ConcreteComponent()
        {
            (this as IComponent<T>).CreateIterator();
        }

        IIterator<T> IComponent<T>.CreateIterator()
        {
            if (iterator == null)
                iterator = new ConcreteIterator<T>(this);

            return iterator;
        }

        List<T> IComponent<T>.GetElements()
        {
            List<T> list = new List<T>();

            list.Add(iterator.First());

            while (!iterator.IsDone())
            {
                list.Add(iterator.Next());
            }

            return list;
        }

        void IComponent<T>.AddElement(T item)
        {
            iterator.AddItem(item);
        }
    }
}