using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Funk_Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parser = int.Parse;

            List<int> input = Console.
                ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(parser)
                .ToList();

            Console.WriteLine(input.Count);
            Console.WriteLine(input.Sum());

        }
    }
}
