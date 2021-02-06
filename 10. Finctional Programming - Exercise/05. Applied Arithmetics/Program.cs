using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            Func<List<int>, string, List<int>> arithmeticFunc = (numbers, command) =>
            {
                if (command == "add")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i]++;
                    }
                }
                else if (command == "multiply")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i]  *= 2;
                    }
                }
                else if (command == "subtract")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i]--;
                    }
                }
                else if (command == "print")
                {
                    Console.WriteLine(String.Join(' ', numbers));
                }

                return numbers;
            };

            while (command != "end")
            {

                numbers = arithmeticFunc(numbers, command);

                command = Console.ReadLine();
            }
        }
    }
}

