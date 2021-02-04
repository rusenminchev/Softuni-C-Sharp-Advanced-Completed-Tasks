using System;
using System.Linq;

namespace Exercise_2._Squares_in_Matrix
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
                char[] currentRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {

                    matrix[row, col] = currentRow[col];
                }

            }

            int counter = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {

                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {

                    if (matrix[row, col] == matrix[row, col + 1] && matrix[row, col] == matrix[row + 1, col] 
                        && (matrix[row, col + 1] == matrix[row + 1, col + 1]))
                        
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
