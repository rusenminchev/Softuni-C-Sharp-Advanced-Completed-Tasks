
using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Linq;

namespace Workshop___Create_Custom_Data_Structures
{
    public class MyList
    {
        private int[] data;
        private int initialCapacity = 4;

        public MyList()
        {
            this.data = new int[initialCapacity];
        }


        public int Count { get; private set; } = 0;

        public int this[int index]
        {
            get
            {
                IndexValidation(index);
                return data[index];
            }
            set
            {
                IndexValidation(index);
                data[index] = value;
            }
        }

        public void Add(int element)
        {
            if (this.data.Length == this.Count)
            {
                Resize();
            }
                this.data[Count] = element;
                this.Count++;
            
        }

        public int RemoveAt(int index)
        {

            var itemToRemove = this.data[index];

            IndexValidation(index);

            ShiftsElementsWhenRemove(index);
            Count--;

            if (this.Count <= this.data.Length / 4)
            {
               Shrink();
            }

            return itemToRemove;
        }
        
        public void InsertAt(int index, int element)
        {
            IndexValidation(index);

            if (this.data.Length == this.Count)
            {
                Resize();
            }

            ShiftElementsWhenInsert(index);

            this.data[index] = element;
            Count++;
        }

        public bool Contains(int element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.data[i] == element)
                {
                    return true;
                }
            }

            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            IndexValidation(firstIndex);
            IndexValidation(secondIndex);

            int temp = this.data[firstIndex];
            this.data[firstIndex] = this.data[secondIndex];
            this.data[secondIndex] = temp;
        }

        private void IndexValidation(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new System.Exception($"The index is out of range. The index must be in range from 0 to {Count - 1}");
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
        private void Shrink()
        {
            int newCapacity = this.data.Length / 2;

            var newData = new int[newCapacity];

            for (int i = 0; i < this.Count; i++)
            {
                newData[i] = this.data[i];
            }

            this.data = newData;
        }
        private void ShiftsElementsWhenRemove(int index)
        {
            for (int i = index; i < this.Count; i++)
            {
                data[i] = data[i + 1];
            }
        }

        private void ShiftElementsWhenInsert(int index)
        {
            for (int i = Count - 1; i >= index; i--)
            {
                data[i + 1] = data[i];
            }
        }
    }
    }

