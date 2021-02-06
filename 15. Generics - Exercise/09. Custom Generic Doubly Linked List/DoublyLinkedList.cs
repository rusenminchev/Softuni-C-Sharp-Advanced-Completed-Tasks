using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Create_Custom_Data_Structures___Custom_Doubly_Linked_List
{
    public class DoublyLinkedList<T> : IEnumerable<T>
    {

        private ListNode<T> head;
        private ListNode<T> tail;

        public int Count { get; private set; }

        public T this[int index]
        {
            get
            {
                T[] array = this.ToArray();

                if (index < 0 || index >= array.Length)
                {
                    throw new ArgumentException("Index is outside of the bounds" +
                        "of the list", nameof(index));
                }

                return array[index];
            }
        }

        public void AddFirst(T element)
        {
            if (this.Count == 0)
            {
                this.head = this.tail = new ListNode<T>(element);
            }
            else
            {
                ListNode<T> newHead = new ListNode<T>(element);
                ListNode<T> oldHead = this.head;

                this.head = newHead;
                newHead.NextNode = oldHead;
                oldHead.PreviousNode = newHead;

            }

            Count++;

        }

        public void AddLast(T element)
        {
            if (this.Count == 0)
            {
                this.head = this.tail = new ListNode<T>(element);
            }
            else
            {
                ListNode<T> newTail = new ListNode<T>(element);
                ListNode<T> oldTail = this.tail;

                this.tail = newTail;
                newTail.PreviousNode = oldTail;
                oldTail.NextNode = newTail;

            }

            Count++;

        }

        public T RemoveFirst()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("List is empty!");
            }

            T firstElement = this.head.Value;


            if (this.Count == 1)
            {
                this.head = null;
                this.tail = null;
            }
            else
            {
                ListNode<T> newHead = this.head.NextNode;
                newHead.PreviousNode = null;
                this.head = newHead;
            }

            Count--;

            return firstElement;
        }


        public T RemoveLast()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("List is empty!");
            }

            T lastElement = this.tail.Value;

            if (this.Count == 1)
            {
                this.head = null;
                this.tail = null;
            }
            else
            {
                ListNode<T> newTail = this.tail.PreviousNode;
                newTail.NextNode = null;
                this.tail = newTail;
            }

            Count--;

            return lastElement;
        }

        public void ForEach(Action<T> action)
        {
            ListNode<T> currentElement = this.head;

            while (currentElement != null)
            {
                action(currentElement.Value);
                currentElement = currentElement.NextNode;

            }
        }

        public T[] ToArray()
        {
            T[] array = new T[this.Count];
            int arrayCounter = 0;
            ListNode<T> currentElement = this.head;

            while (currentElement != null)
            {
                array[arrayCounter] = currentElement.Value;
                currentElement = currentElement.NextNode;
                arrayCounter++;
            }

            return array;
        }

        public IEnumerator<T> GetEnumerator()
        {

            ListNode<T> currentElement = this.head;

            while (currentElement != null)
            {
                yield return currentElement.Value;
                currentElement = currentElement.NextNode;
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
