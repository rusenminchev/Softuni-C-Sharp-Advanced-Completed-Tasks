using System;
using System.ComponentModel;
using System.Linq;

namespace Stack
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string command = Console.ReadLine();

            myStack<int> myStack = new myStack<int>();

            while (command !="END")
            {
                if (command.Contains("Push"))
                {
                    var input = command
                        .Split(new[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .Skip(1)
                        .ToList();

                    for (int i = 0; i < input.Count; i++)
                    {
                        myStack.Push(input[i]);
                    }

                }
                else if (command.Contains("Pop"))
                {
                    try
                    {
                        myStack.Pop();
                    }
                    catch(InvalidOperationException exception)
                    {
                        Console.WriteLine(exception.Message);
                    }         
                }


                command = Console.ReadLine();
            }

            foreach (var element in myStack)
            {
                Console.WriteLine(element);
            }
             foreach (var element in myStack)
            {
                Console.WriteLine(element);
            }

        }
    }
}
