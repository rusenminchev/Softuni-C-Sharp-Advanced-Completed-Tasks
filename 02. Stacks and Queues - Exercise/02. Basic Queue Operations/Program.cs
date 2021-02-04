using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

namespace Problem_1._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var elementsToEnqueue = commands[0];
            var elementsToDequeue = commands[1];
            var isItConatains = commands[2];

            int smallest = int.MaxValue;


            int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> numbers = new Queue<int>();

            for (int i = 0; i < elementsToEnqueue; i++)
            {
                numbers.Enqueue(ints[i]);
            }

            for (int i = 0; i < elementsToDequeue; i++)
            {
                numbers.Dequeue();
            }

            if (!numbers.Any())
            {
                Console.WriteLine(0);
                return;
            }


            if (numbers.Contains(isItConatains))
            {
                Console.WriteLine("true");
            }
            else
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    var currentInt = numbers.Dequeue();
                    if (smallest > currentInt)
                    {
                        smallest = currentInt;
                    }
                    numbers.Enqueue(currentInt);
                }
                Console.WriteLine(smallest);
            }
            
            
        }
    }
}
