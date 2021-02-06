using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GenericCountMethodStrings
{
    public class Box<T> where T : IComparable
    {

        private List<T> elements;

        public Box(List<T> elements)
        {
            this.elements = elements;
        }

        public void Swap(List<T> list, int firstIndex, int secondIndex)
        {
            T temp = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;

        }

        public int CounterOfLargerElements(List<T> elements, T elementToCompare)
        {
            int count = 0;

            foreach (var element in elements)
            {
                int comparison = elementToCompare.CompareTo(element);

                if (comparison < 0 )
                { 
                 count++;
                }
            }

            return count;

        }
    }
}
