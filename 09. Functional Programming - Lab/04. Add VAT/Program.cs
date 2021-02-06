using System;
using System.Linq;

namespace Func_Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(x => x + (x * 0.2))
                .ToList();

            foreach (var number in input)
            {
                Console.WriteLine($"{number:f2}");
            }
        }
    }
}
