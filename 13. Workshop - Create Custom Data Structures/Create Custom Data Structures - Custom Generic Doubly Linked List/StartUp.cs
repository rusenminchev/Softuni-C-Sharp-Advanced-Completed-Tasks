using System;

namespace Create_Custom_Data_Structures___Custom_Doubly_Linked_List
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<string> myDoublyLinkedList = new DoublyLinkedList<string>();

            for (int i = 1; i <= 10; i++)
            {

                myDoublyLinkedList.AddFirst("Rusen" + i);

            }

            for (int i = 1; i <= 10; i++)
            {

                myDoublyLinkedList.AddLast("Rusen" + i);

            }

            myDoublyLinkedList.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {

                myDoublyLinkedList.RemoveFirst();

            }

            Console.WriteLine();
            Console.WriteLine("---");

            myDoublyLinkedList.ForEach(x => Console.Write(x + " "));

            Console.WriteLine();
            Console.WriteLine("---");

            string[] array = myDoublyLinkedList.ToArray();

            Console.WriteLine();
            Console.WriteLine("---");


            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("---");

            Console.WriteLine(myDoublyLinkedList[5]);

            Console.WriteLine();
            Console.WriteLine("---");

            foreach (var element in myDoublyLinkedList)
            {
                Console.WriteLine(element);
            }

        }
    }
}
