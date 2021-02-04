using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_3._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> uniqueEl = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {

                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int j = 0; j < input.Length; j++)
                {

                    uniqueEl.Add(input[j]);
                }
            }

            foreach (var element in uniqueEl.OrderBy(x => x))
            {

                Console.Write(element + " ");

            }

        }
    }
}
