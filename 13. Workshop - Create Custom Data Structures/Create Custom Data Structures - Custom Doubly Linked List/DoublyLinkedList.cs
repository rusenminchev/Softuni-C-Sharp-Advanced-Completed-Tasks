using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Create_Custom_Data_Structures___Custom_Doubly_Linked_List
{
    public class DoublyLinkedList
    {

        private ListNode head;
        private ListNode tail;

        public int Count { get; private set; }

        public void AddFirst(int element)
        {
            if (Count == 0)
            {
                this.head = this.tail = new ListNode(element);
            }
            else
            {
                ListNode newHead = new ListNode(element);
                ListNode oldHead = this.head;

                this.head = newHead;
                newHead.NextNode = oldHead;
                oldHead.PreviousNode = newHead;

            }
            Count++;
        }


        public void AddLast(int element)
        {
            if (Count == 0)
            {
                this.head = this.tail = new ListNode(element);
            }
            else
            {
                ListNode newTail = new ListNode(element);
                ListNode oldTail = this.tail;

                this.tail = newTail;
                newTail.PreviousNode = oldTail;
                oldTail.NextNode = newTail;

            }

            Count++;

        }

        public int RemoveFirst()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("List is empty!");
            }

            //int? firstElement = this.head?.Value;
            int firstElement = this.head.Value;


            if (Count == 1)
            {
                this.head = null;
                this.tail = null;
            }
            else
            {
                ListNode newHead = this.head.NextNode;
                newHead.PreviousNode = null;
                this.head = newHead;
            }

            Count--;

            return firstElement;
        }


        public int RemoveLast()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("List is empty!");
            }

            //int? lastElement = this.tail?.Value;
            int lastElement = this.tail.Value;

            if (Count == 1)
            {
                this.head = null;
                this.tail = null;
            }
            else
            {
                ListNode newTail = this.tail.PreviousNode;
                newTail.NextNode = null;
                this.tail = newTail;
            }

            Count--;

            return lastElement;
        }

        public void ForEach(Action<int> action)
        {
            ListNode currentElement = this.head;

            while (currentElement != null)
            {
                action(currentElement.Value);
                currentElement = currentElement.NextNode;

            }
        }

        public int[] ToArray()
        {
            int[] array = new int[this.Count];
            int arrayCounter = 0;

            ListNode currentElement = this.head;

            while (currentElement != null)
            {
                array[arrayCounter] = currentElement.Value;
                currentElement = currentElement.NextNode;
                arrayCounter++;
            }

            //for (int i = 0; i < this.Count; i++)
            //{
            //     array[i] = currentElement.Value;
            //    currentElement = currentElement.NextNode;
            //}

            return array;
        }
    }
}
