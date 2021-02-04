using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Reflection.Metadata;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(input);

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] cmdArgs = command.Split();

                if (command.Contains("add"))
                {
                    int num1 = int.Parse(cmdArgs[1]);
                    int num2 = int.Parse(cmdArgs[2]);

                    stack.Push(num1);
                    stack.Push(num2);
                }
                else if (command.Contains("remove"))
                {
                    int num1 = int.Parse(cmdArgs[1]);

                    if (num1 <= stack.Count)
                    {
                        for (int i = 1; i <= num1; i++)
                        {
                            stack.Pop();
                        }
                    }
                }


                command = Console.ReadLine().ToLower();
            }

            int sum = 0;

            foreach (var num in stack)
            {
                sum += num;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
