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

            var elementsToPush = commands[0];
            var elementsToPop = commands[1];
            var isItConatains = commands[2];

            int smallest = int.MaxValue;


            int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < elementsToPush; i++)
            {
                numbers.Push(ints[i]);
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                if (numbers.Any())
                {
                    numbers.Pop();
                }
            }

            if (numbers.Contains(isItConatains))
            {
                Console.WriteLine("true");
            }
            else if (!numbers.Any())
            {
                Console.WriteLine(0);
            }
            else
            {
                
                // Interesna formulirovka, която включа и проверка, ако случайно стека е празен, за да избегне ексепшън и да даде аутпут 0.
                Console.WriteLine(numbers.Count > 0 ? numbers.Min() : 0);
            }

        }
    }
}
