using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            int rows = matrixSize;
            int cols = matrixSize;

            var matrix = new int[rows, cols];

            FillTheMatrix(rows, cols, matrix);
            
            int sum = 0;

            for (int i = 0; i < cols; i++)
            {
                sum += matrix[i, i];
            }

            Console.WriteLine(sum);
        }
        static List<int> ReadingMatrixArgs()
            => Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

        static void FillTheMatrix(int rows, int cols, int[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                var input = ReadingMatrixArgs();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
    }
}
