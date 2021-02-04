using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>(Console.ReadLine());

            while (stack.Any())
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
