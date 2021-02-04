using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = string.Empty;

            Queue<String> names = new Queue<string>();

            while ((input = Console.ReadLine()) != "End")
            {
                if (input != "Paid")
                {
                    names.Enqueue(input);
                }
                else
                {
                    Console.WriteLine(String.Join(Environment.NewLine, names));
                    names.Clear();
                }
            }
            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
