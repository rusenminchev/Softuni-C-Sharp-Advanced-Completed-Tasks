using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _12._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            Func<string, int, bool> namesSumfunc = (x, y) => x.Select(c => (int)c).Sum() >= y;

            Func<List<string>, Func<string, int, bool>, string> nameFunc = (x, y)  =>
            {

                string outputName = string.Empty;

                for (int i = 0; i < x.Count; i++)
                {
                    if (y(x[i], n))
                    {
                        outputName = x[i];
                        break;
                    }
                }

                return outputName;
            };

            Console.WriteLine(nameFunc(names, namesSumfunc));
        }
    }
}
