using System;
using System.Linq;

namespace Exercise_03._Custom_Min_Function_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int[], int> minFunc = nums =>
            {

                int min = int.MaxValue;

                foreach (var num in numbers)
                {
                    if (num < min)
                    {
                        min = num;
                    }

                }

                return min;

            };

            Console.WriteLine(minFunc(numbers));
        }
    }
}
