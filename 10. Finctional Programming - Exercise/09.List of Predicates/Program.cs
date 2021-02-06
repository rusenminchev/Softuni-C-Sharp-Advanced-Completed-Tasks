using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_09._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> deviders = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> devidibleNumbers = new List<int>();

            for (int j = 1; j <= n; j++)
            {
                bool isDevideble = true;

                foreach (var devider in deviders)
                {
                    Func<int, bool> devidebleFunc = x => x % devider == 0;

                    if (!devidebleFunc(j))
                    {
                        isDevideble = false; 
                    }
                }

                if (isDevideble)
                {
                    devidibleNumbers.Add(j);
                }
            }

            Console.WriteLine(String.Join(' ', devidibleNumbers));
        }
    }
}
