using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();
            int devider = int.Parse(Console.ReadLine());

            Func<List<int>, int, List<int>> isItDevidebleFunc = (numbers, devider) =>
            {
                List<int> output = new List<int>();
                foreach (var num in numbers)
                {
                    if (num % devider != 0)
                    {
                        output.Add(num);
                    }
                }
                return output;
            };

            numbers = isItDevidebleFunc(numbers, devider);

            Console.WriteLine(String.Join(' ', numbers));

        }
    }
}
