using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace Problem_3._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> numbers = new Stack<int>();

            int minimum = int.MaxValue;
            int maximum = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int queryType = input[0];

                switch (queryType)
                {
                    case 1:
                        int element = input[1];

                        numbers.Push(element);

                        break;
                    case 2:
                        if (numbers.Any())
                        {
                            numbers.Pop();
                        }

                        break;
                    case 3:
                        if (numbers.Any())
                        {
                            for (int k = 0; k < numbers.Count; k++)
                            {

                                int currentNumber = numbers.Peek();
                                if (maximum < currentNumber)
                                {
                                    maximum = currentNumber;
                                    Console.WriteLine(maximum);
                                }

                            }

                        }

                        break;

                    case 4:

                        if (numbers.Any())
                        {
                            for (int j = 0; j < numbers.Count; j++)
                            {
                                int currentNumber = numbers.Peek();
                                if (minimum > currentNumber)
                                {
                                    minimum = currentNumber;
                                    Console.WriteLine(minimum);
                                }
                            }
                        }

                        break;
                }
            }

            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}
