using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            String text = Console.ReadLine();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];

                if (ch == '(')
                {
                    stack.Push(i);

                }
                else if (ch == ')')
                {
                    int startIndex = stack.Pop();

                    string subStrings = text.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(subStrings);
                }
            }
        }
    }
}
