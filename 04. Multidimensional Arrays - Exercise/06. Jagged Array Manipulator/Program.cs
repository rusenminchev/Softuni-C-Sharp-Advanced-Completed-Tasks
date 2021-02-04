using System;
using System.Linq;

namespace Exercise_6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int nRows = int.Parse(Console.ReadLine());

            int[][] jaggegArrey = new int[nRows][];


            for (int row = 0; row < nRows; row++)
            {
                int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                jaggegArrey[row] = input;
            }

            for (int row = 0; row < jaggegArrey.GetLength(0); row++)
            {
                if (jaggegArrey[row].Length == jaggegArrey[row + 1].Length)
                {
                    for (int i = 0; i < jaggegArrey[row].Length; i++)
                    {

                        jaggegArrey[row][i] *= 2;

                    }
                    for (int i = 0; i < jaggegArrey[row + 1].Length; i++)
                    {

                        jaggegArrey[row + 1][i] *= 2;

                    }
                }
                else
                {
                    for (int i = 0; i < jaggegArrey[row].Length; i++)
                    {

                        jaggegArrey[row][i] /= 2;

                    }
                    for (int i = 0; i < jaggegArrey[row + 1].Length; i++)
                    {

                        jaggegArrey[row + 1][i] /= 2;

                    }

                }

            }

        }
    }
}
