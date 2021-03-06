﻿using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];
            int sum = 0;

            Console.WriteLine(rows);
            Console.WriteLine(cols);

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {

                    matrix[row, col] = currentRow[col];
                }

            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int currentColSum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {

                    currentColSum += matrix[row, col];

                }
                Console.WriteLine(currentColSum);
            }
        }
    }
}
