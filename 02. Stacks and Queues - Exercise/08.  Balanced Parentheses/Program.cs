using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_8.__Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string leftSide = input.Substring(0, input.Length / 2);
            string rightSide = input.Substring((input.Length / 2), input.Length / 2);

            Stack<char> leftSideStack = new Stack<char>(leftSide);
            Stack<char> rightSideStack = new Stack<char>(rightSide.Reverse());

            bool isBalanced = true;

            if (leftSideStack.Count < 1 && rightSideStack.Count < 1)
            {
                isBalanced = false;
            }

          

            for (int i = 0; i < leftSide.Length; i++)
            {
                char currLeft = leftSideStack.Pop();
                char currRight = rightSideStack.Pop();

                if (currLeft == '(' && !(currRight == ')'))
                {
                    isBalanced = false;
                }
                else if (currLeft == '[' && !(currRight == ']'))
                {
                    isBalanced = false;
                }
                else if (currLeft == '{' && !(currRight == '}'))
                {
                    isBalanced = false;
                }
                else if (currLeft == ' ' && !(currRight == ' '))
                {
                    isBalanced = false;
                }
            }
            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
