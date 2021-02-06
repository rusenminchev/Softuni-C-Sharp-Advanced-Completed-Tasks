using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace GenericCountMethodStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> elements = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                elements.Add(input);
            }

            string elementToCompare = Console.ReadLine();

            Box<string> box = new Box<string>(elements);

            Console.WriteLine(box.CounterOfLargerElements(elements, elementToCompare));
        }
    }
}
