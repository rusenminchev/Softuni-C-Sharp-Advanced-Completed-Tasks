using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
   public class myStack<T> : IEnumerable<T>
    {
        private List<T> data;

        public myStack()
        {
            this.data = new List<T>();
        }

        public void Push(T element)
        {
            this.data.Add(element);
        }

        public void Pop()
        {
            if (this.data.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }
            
                this.data.Remove(this.data[this.data.Count - 1]);
            
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.data.Count - 1; i >= 0; i--)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
