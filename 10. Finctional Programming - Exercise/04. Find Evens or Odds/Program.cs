using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            var ranges = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string filter = Console.ReadLine();

            Predicate<int> predicate = filter == "odd" ?
                new Predicate<int>(n => n % 2 != 0) : new
                Predicate<int>(n => n % 2 == 0);

            List<int> result = new List<int>();

            for (int i = ranges[0]; i <= ranges[1]; i++)
            {
                if (predicate(i))
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
