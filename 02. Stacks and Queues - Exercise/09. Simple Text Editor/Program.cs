using System;
using System.Collections.Generic;

namespace Problem_9.__Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());

            string input = string.Empty;
            Stack<string> undoList = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string cmd = cmdArgs[0];

                if (cmd == "1")
                {
                    undoList.Push(input);
                    input = input + cmdArgs[1];

                }
                else if (cmd == "2")
                {
                    int count = int.Parse(cmdArgs[1]);
                    undoList.Push(input);


                    if (input.Length >= count)
                    {
                        input = input.Remove(input.Length - int.Parse(cmdArgs[1]), int.Parse(cmdArgs[1]));
                    }
                }
                else if (cmd == "3")
                {

                    Console.WriteLine(input[int.Parse(cmdArgs[1]) - 1]);

                }
                else if (cmd == "4")
                {
                    if (undoList.Count > 0)
                    {
                        input = undoList.Pop();
                    }
                    else
                    {
                        input = string.Empty;
                    }
                }
            }
        }
    }
}
