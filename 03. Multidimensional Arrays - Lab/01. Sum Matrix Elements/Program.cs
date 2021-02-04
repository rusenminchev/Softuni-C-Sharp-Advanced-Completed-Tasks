using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
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
                int[] currentRow = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {

                    matrix[row, col] = currentRow[col];
                }

            }

            // ако трябва да се намери сумата на всички елементи 

            //for (int row2 = 0; row2 < rows; row2++)
            //{

            //    for (int col2 = 0; col2 < cols; col2++)
            //    {
            //        sum += matrix[row2, col2];
            //    }

            //}

            foreach (var element in matrix)
            {
                sum += element;
            }

            // Решение с linq

            sum = matrix.Cast<int>().Sum();

            Console.WriteLine(sum);
        }
    }
}
