using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace JaggedArray_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                jaggedArray[row] = currentRow;

            }

            string command;

            while ((command = Console.ReadLine()) != "END")
            {

                string[] cmdArgs = command.Split();
                string cmd = cmdArgs[0];
                int row = int.Parse(cmdArgs[1]);
                int col = int.Parse(cmdArgs[2]);
                int value = int.Parse(cmdArgs[3]);

                if (row <= jaggedArray.Length - 1 && row > - 1 && col <= jaggedArray[row].Length -1  && col > -1)
                {
                    if (cmd == "Add")
                    {
                        jaggedArray[row][col] += value;
                    }
                    else if (cmd == "Subtract")
                    {
                        jaggedArray[row][col] -= value;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
            }

            foreach (var element in jaggedArray)
            {
                Console.WriteLine(String.Join(' ', element));
            }
        }
    }
}
