using System;
using System.Linq;

namespace CS_Advanced___Functional_Programming
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .OrderBy(x => x)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
