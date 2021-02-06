using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace GenericSwapMethodStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                list.Add(input);
            }

            int[] indexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int firstIndex = indexes[0];
            int secondIndex = indexes[1];


            Box<string> box = new Box<string>(list);

           box.Swap(list, firstIndex, secondIndex);

            Console.WriteLine(box);
        }
    }
}
