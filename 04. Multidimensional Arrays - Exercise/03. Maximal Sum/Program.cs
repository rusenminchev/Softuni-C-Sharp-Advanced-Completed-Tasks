using System;
using System.Linq;

namespace Exercise_3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int rows = n[0];
            int cols = n[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {

                    matrix[row, col] = currentRow[col];
                }

            }

            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {

                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {

                    int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                         + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                         + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (maxSum < currentSum)
                    {
                        maxSum = currentSum;
                        maxRow = row;
                        maxCol = col;   
                    }

                }
            }
            Console.WriteLine("Sum = " + maxSum);

            for (int row2 = maxRow; row2 < maxRow + 3; row2++)
            {

                for (int col2 = maxCol; col2 < maxCol + 3; col2++)
                {
                    Console.Write($"{ matrix[row2, col2]} ");
                }

                Console.WriteLine();
            }
            }
        }
    }
