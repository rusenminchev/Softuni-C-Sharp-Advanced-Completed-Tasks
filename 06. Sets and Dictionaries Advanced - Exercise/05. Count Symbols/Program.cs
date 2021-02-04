using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_5._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> chars = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!chars.ContainsKey(input[i]))
                {
                    chars.Add(input[i], 1);

                }
                else
                {
                    chars[input[i]]++;
                }
            }

            foreach (var (character, count) in chars.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{character}: {count} time/s");
            }
        }
    }
}
