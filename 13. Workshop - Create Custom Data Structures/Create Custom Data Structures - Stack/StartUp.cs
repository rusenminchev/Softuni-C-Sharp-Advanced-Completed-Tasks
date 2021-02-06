using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Workshop___Create_Custom_Data_Structures;

namespace Create_Custom_Data_Structures___Stack
{
    class StartUp
    {
        static void Main(string[] args)
        {
            MyStack myStack = new MyStack();

            Console.WriteLine("Let`s push some elements in our custom stack");

            myStack.Push(0);
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            myStack.Push(6);
            myStack.Push(7);
            myStack.Push(8);
            myStack.Push(9);

            Console.WriteLine("Let`s check the count of the stack");

            Console.WriteLine(myStack.Count);

            Console.WriteLine("It`s time to Pop() a few elements");

            myStack.Pop();
            myStack.Pop();
            myStack.Pop();

            Console.WriteLine("Let`s check the count again");

            Console.WriteLine(myStack.Count);

            Console.WriteLine("Is the Peek() method working?");

            Console.WriteLine(myStack.Peek());

            Console.WriteLine("Hell yeah!");

            Console.WriteLine("Let`s implement ForEach() loop and apply an action to the elements in the stack");

            Action<int> action = x => Console.WriteLine(x * 10);

            myStack.ForEach(action);

            Console.WriteLine(myStack.Count);



        }
    }
}
