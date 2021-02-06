using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace GenericSwapMethodIntegers
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                list.Add(input);
            }

            int[] indexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int firstIndex = indexes[0];
            int secondIndex = indexes[1];


            Box<int> box = new Box<int>(list);

           box.Swap(list, firstIndex, secondIndex);

            Console.WriteLine(box);
        }
    }
}
