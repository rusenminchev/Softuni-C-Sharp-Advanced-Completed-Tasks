using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Exercise_2._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];
            
            HashSet<int> nNums = new HashSet<int>();
            HashSet<int> mNums = new HashSet<int>();
            HashSet<int> matchingNums = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int nElements = int.Parse(Console.ReadLine());
                nNums.Add(nElements);
            }

            for (int i = 0; i < m; i++)
            {
                int mElements = int.Parse(Console.ReadLine());
                mNums.Add(mElements);
            }

            foreach (var num in nNums)
            {
                foreach (var numM in mNums)
                {
                    if (num == numM)
                    {
                        matchingNums.Add(num);
                    }
                }
            }

            foreach (var num in matchingNums)
            {
                Console.Write(num + " ");
            }
        }
    }
}
