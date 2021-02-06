
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Linq;

namespace Workshop___Create_Custom_Data_Structures
{
    public class MyStack
    {
        private int[] data;
        private int initialCapacity = 4;


        public MyStack()
        {
            this.Count = 0;
            this.data = new int[initialCapacity];
        }


        public int Count { get; private set; }


        public void Push(int element)
        {
            if (this.data.Length == this.Count)
            {
                Resize();
            }
            this.data[Count] = element;
            this.Count++;

        }

        public int Pop()
        {
            ValidateStack();

            int lastElement = this.data[this.Count - 1];
            Count--;
            return lastElement;
        }

        public int Peek()
        {
            ValidateStack();
            return this.data[this.Count - 1];
        }

        

        public void ForEach(Action<int> action)
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                action(this.data[i]);
            }
        }

        private void ValidateStack()
        {
            if (this.Count == 0)
            {
                throw new InvalidAsynchronousStateException("The stack is empty");
            }
        }

        private void Resize()
        {
            int newCapacity = this.data.Length * 2;

            var newData = new int[newCapacity];

            for (int i = 0; i < this.Count; i++)
            {
                newData[i] = this.data[i];
            }

            this.data = newData;
        }

        
    }
}

