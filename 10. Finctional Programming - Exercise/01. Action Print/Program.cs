using System;
using System.Globalization;
using System.Linq;

namespace Exercise___01._Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printAction = Console.WriteLine;

            Console
                .ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(printAction);

            //ver. 2

            string[] names = Console.ReadLine().Split();

            Action<string[]> printAction2 = x => Console.WriteLine(String.Join(Environment.NewLine, x));

            printAction2(names);
        }
    }
}
