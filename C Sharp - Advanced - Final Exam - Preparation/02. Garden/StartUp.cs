using System;
using System.Collections.Generic;
using System.Linq;

namespace Garden
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = matrixSize[0];
            int m = matrixSize[0];

            int[,] matrix = new int[n, m];

            List<int> validCoordinatesRows = new List<int>();
            List<int> validCoordinatesCols = new List<int>();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = 0;
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Bloom Bloom Plow")
                {
                    break;
                }

                int[] coodrinates = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int flowerRow = coodrinates[0];
                int flowerCol = coodrinates[1];

                if(!IsInTheMatrix(matrix, flowerRow, flowerCol))
                {
                    Console.WriteLine("Invalid coordinates.");
                    continue;
                }

                validCoordinatesRows.Add(flowerRow);
                validCoordinatesCols.Add(flowerCol);
            }

            for (int i = 0; i < validCoordinatesRows.Count; i++)
            {
                for (int rows = 0; rows < matrix.GetLength(0); rows++)
                {
                    matrix[rows, validCoordinatesCols[i]]++;
                }

                matrix[validCoordinatesRows[i], validCoordinatesCols[i]]--;

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[validCoordinatesRows[i], cols] ++;
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static bool IsInTheMatrix(int[,] matrix, int flowerRow, int flowerCol)
        {
            return flowerRow >= 0 && flowerRow < matrix.GetLength(0) &&
                   flowerCol >= 0 && flowerCol < matrix.GetLength(1);
        }
    }
}
