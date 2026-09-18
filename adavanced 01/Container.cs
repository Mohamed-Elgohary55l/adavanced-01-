using System;
using System.Collections.Generic;
using System.Text;

namespace adavanced_01
{
    internal class Container<T>
    {
        List<T> l = new List<T>();
        public void Add(T item)
        {
            l.Add(item);
        }

        public T Get (int index)
        {
            if (index < 0 || index >= l.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }

            return l[index];
        }
    }
}
