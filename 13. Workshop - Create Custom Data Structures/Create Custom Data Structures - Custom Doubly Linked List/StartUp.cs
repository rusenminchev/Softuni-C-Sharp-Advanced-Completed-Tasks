using System;

namespace Create_Custom_Data_Structures___Custom_Doubly_Linked_List
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            DoublyLinkedList myDoublyLinkedList = new DoublyLinkedList();

            for (int i = 1; i <= 10; i++)
            {

                myDoublyLinkedList.AddFirst(i);

            }
            
            for (int i = 1; i <= 10; i++)
            {

                myDoublyLinkedList.AddLast(i);

            }

           

            myDoublyLinkedList.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {

                myDoublyLinkedList.RemoveFirst();

            }

            myDoublyLinkedList.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();

            int[] array = myDoublyLinkedList.ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
