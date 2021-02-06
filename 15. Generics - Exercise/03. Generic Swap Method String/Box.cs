using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodStrings
{
    public class Box<T>
    {

        private List<T> value;

        public Box(List<T> value)
        {
            this.value = value;
        }

        public void Swap(List<T> list, int firstIndex, int secondIndex)
        {
            T temp = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in this.value)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }
            
            return sb.ToString().TrimEnd();
        }
    }
}
