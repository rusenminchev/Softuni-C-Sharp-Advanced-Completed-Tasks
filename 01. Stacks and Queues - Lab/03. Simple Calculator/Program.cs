using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Stack<string> stack = new Stack<string>(input.Reverse());

            while (stack.Count > 1)
            {
                int num1 = int.Parse(stack.Pop());
                string operation = stack.Pop();
                int num2 = int.Parse(stack.Pop());

                int tempNum = 0;

                switch (operation)
                {
                    case "-":
                        tempNum = num1 - num2;
                        break;
                    case "+":
                        tempNum = num1 + num2;
                        break;
                    default:
                        tempNum = 0;
                        break;
                }


                stack.Push(tempNum.ToString());
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
