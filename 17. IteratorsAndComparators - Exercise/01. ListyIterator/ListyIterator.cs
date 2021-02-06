using System;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T>
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
                throw new InvalidOperationException("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(this.data[this.count]);
            }  
        }

        public bool HasNext()
        {
            return this.count + 1 < this.data.Count;
        }
    }
}
