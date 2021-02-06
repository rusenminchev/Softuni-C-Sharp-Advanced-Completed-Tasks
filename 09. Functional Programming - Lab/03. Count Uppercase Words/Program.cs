using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Func_Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> checker = input => char.IsUpper(input[0]);

            Console.ReadLine()
                 .Split()
                 .Where(checker)
                 .ToList()
                 .ForEach(Console.WriteLine);

        }
    }
}
