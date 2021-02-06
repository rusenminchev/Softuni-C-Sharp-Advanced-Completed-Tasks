using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> data;
        private int count;

        public ListyIterator(params T[] data)
        {
            this.data = new List<T>(data);
        }


        public bool Move()
        {
            this.count++;

            return count < data.Count;
        }

        public void Print()
        {
            if (this.data.Count == 0)
            {
                Console.WriteLine("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(this.data[this.count]);
            }
            
        }

        public bool HasNext()
        {
            return this.count + 1 < data.Count;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.data)
            {
                yield return item;
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
