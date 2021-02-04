using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise___1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int rows = n;
            int cols = n;

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {

                    matrix[row, col] = currentRow[col];
                }

            }

            int firstDiagonal = 0;
            int secondDiagonal = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                firstDiagonal += matrix[row, row];
                
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                secondDiagonal += matrix[row, matrix.GetLength(0) - 1 - row];

            }

            int diff = Math.Abs(firstDiagonal - secondDiagonal);

            Console.WriteLine(diff);
            
        }
    }
}
