using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace adavanced_01
{
    internal class Container<T> where T : IComparable
    {
        List<T> l = new List<T>();
        public void Add(T item)
        {
            l.Add(item);
        }

        public T Get(int index)
        {
            if (index < 0 || index >= l.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }

            return l[index];
        }
        public void Swap<T1>(T1 first, T1 second)
        {
            T1 temp;
            temp = first;
            first = second;
            second = temp;




        }

        public T FindMax(T[] arr)
        {
            T max = arr[0];

            for (int i =1; i < arr.Length; i++) {

                if (arr[i].CompareTo(max)>0)
                {
                    max = arr[i];
                }
            }
            return max;



        }
    } 

}
