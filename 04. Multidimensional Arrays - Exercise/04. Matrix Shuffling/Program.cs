using Microsoft.VisualBasic;
using System;
using System.Linq;

namespace Exercise_4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] n = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int rows = n[0];
            int cols = n[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] currentRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < cols; col++)
                {

                    matrix[row, col] = currentRow[col];
                }

            }

            string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "END")
            {
                

                if (command[0] == "swap" && command.Length == 5)
                {
                    string cmd = command[0];
                    int row1 = int.Parse(command[1]);
                    int col1 = int.Parse(command[2]);
                    int row2 = int.Parse(command[3]);
                    int col2 = int.Parse(command[4]);
                    
                    if (row1 < 0 || row1 > matrix.GetLength(0) -1 || row2 < 0 || row2 > matrix.GetLength(0) -1 ||
                        col1 < 0 || col1 > matrix.GetLength(1) - 1 || col2 < 0 || col2 > matrix.GetLength(1) - 1)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        string temp = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = temp;

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {

                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write($"{matrix[row, col]} ");
                            }

                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

        }
    }
}
