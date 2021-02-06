using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BoxOfT
{
    public class Box<T>
    {

        private List<T> data;

        public Box()
        {
            this.data = new List<T>();
        }

        public void Add(T element)
        {
            this.data.Add(element);
        }

        public T Remove()
        {

            var result = this.data[data.Count - 1];
            data.Remove(data[data.Count - 1]);
            return result;
        }
    }
}
