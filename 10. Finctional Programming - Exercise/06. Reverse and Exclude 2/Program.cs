using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_06._Reverse_and_Exclude_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();
            int devider = int.Parse(Console.ReadLine());

            Func<int, bool> predicate = x => x % devider != 0;

            numbers = numbers.Where(predicate).ToList();
            //numbers = numbers.Where(x => x % devider != 0).ToList();

            Console.WriteLine(String.Join(' ', numbers));

        }
    }
}
