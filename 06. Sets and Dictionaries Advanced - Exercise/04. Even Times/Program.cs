using System;
using System.Collections.Generic;

namespace Exercise_4._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (!numbers.ContainsKey(input))
                {
                    numbers.Add(input, 1);
                }
                else
                {
                    numbers[input]++;
                }
            }

            foreach (var (key, value) in numbers)
            {
                if (value % 2 == 0)
                {
                    Console.WriteLine(key);
                }
            }
        }
    }
}
