using System;
using System.Collections.Generic;

namespace Exercise_6._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wordrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string color = input[0];
                string[] clothes = input[1].Split(",");

                if (!wordrobe.ContainsKey(color))
                {
                    wordrobe.Add(color, new Dictionary<string, int>());
                }

                foreach (var item in clothes)
                {
                        if (!wordrobe[color].ContainsKey(item))
                        {
                            wordrobe[color].Add(item, 0);
                        }
                        
                            wordrobe[color][item]++;
                }
            }

            var toFind = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string colorToFind = toFind[0];
            string clothing = toFind[1];

            foreach (var (color, clothings) in wordrobe)
            {
                Console.WriteLine($"{color} clothes:");

                foreach (var (clothes, count) in clothings)
                {
                    if (colorToFind == color && clothing == clothes)
                    {
                        Console.WriteLine($"* {clothes} - {count} (found!)");
                    }
                    else
                    {

                        Console.WriteLine($"* {clothes} - {count}");
                    }
                }
            }
        }
    }
}
