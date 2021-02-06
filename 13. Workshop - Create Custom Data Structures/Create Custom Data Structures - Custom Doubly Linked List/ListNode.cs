using System;
using System.Collections.Generic;
using System.Text;

namespace Create_Custom_Data_Structures___Custom_Doubly_Linked_List
{
    public class ListNode
    {
        public ListNode(int value)
        {
            this.Value = value;
        }

        public int Value { get; set; }
        public ListNode NextNode { get; set; }
        public ListNode PreviousNode { get; set; }


    }
}
