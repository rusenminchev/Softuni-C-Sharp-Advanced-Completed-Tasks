using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace GenericCountMethodDoubles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<double> elements = new List<double>();

            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());

                elements.Add(input);
            }

            double elementToCompare = double.Parse(Console.ReadLine());

            Box<double> box = new Box<double>(elements);

            Console.WriteLine(box.CountOfTheLargerElements(elements, elementToCompare));
        }
    }
}
