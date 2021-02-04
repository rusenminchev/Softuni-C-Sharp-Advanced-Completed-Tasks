using System;
using System.Linq;

namespace Exercise_5._Snake_Moves
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

           
                string[] currentRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < cols; col++)
                { 

                    matrix[0, col] = currentRow[col];
                }
            


        }
    }
}
