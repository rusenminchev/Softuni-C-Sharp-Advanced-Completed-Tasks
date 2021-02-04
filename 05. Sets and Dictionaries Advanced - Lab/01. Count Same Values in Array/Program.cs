using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Count_Same_Values_in_Array
{
    class Program
    {
        public static object Disctional { get; private set; }

        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToArray();

            Dictionary<double, int> sameValues = new Dictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (sameValues.ContainsKey(input[i]))
                {

                    sameValues[input[i]] += 1;
                }
                else
                {
                    sameValues.Add(input[i], 1);
                }
            }

            foreach (var (value, counter) in sameValues)
            {

                Console.WriteLine($"{value} - {counter} times");

            }
        }
    }
}
