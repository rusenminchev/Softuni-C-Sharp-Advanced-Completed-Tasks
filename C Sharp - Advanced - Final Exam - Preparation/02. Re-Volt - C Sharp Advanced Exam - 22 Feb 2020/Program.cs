using System;
using System.Runtime.InteropServices;

namespace _02._Re_Volt___C_Sharp_Advanced_Exam___22_Feb_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int commandsCount = int.Parse(Console.ReadLine());

            int playersRow = -1;
            int playersCol = -1;

            char[,] matrix = new char[n, n];

            CreateMatrix(ref playersRow, ref playersCol, matrix);

            for (int i = 0; i < commandsCount; i++)
            {

                string command = Console.ReadLine();

                matrix[playersRow, playersCol] = '-';

                if (command == "up")
                {
                    playersRow--;
                }
                else if (command == "down")
                {
                    playersRow++;
                }
                else if (command == "left")
                {
                    playersCol--;
                }
                else if (command == "right")
                {
                    playersCol++;
                }

                if (!IsItOutOfTheMatrix(matrix, playersRow, playersCol))
                {
                    if (matrix[playersRow, playersCol] == 'B')
                    {
                        if (command == "up")
                        {
                            playersRow--;
                        }
                        else if (command == "down")
                        {
                            playersRow++;
                        }
                        else if (command == "left")
                        {
                            playersCol--;
                        }
                        else if (command == "right")
                        {
                            playersCol++;
                        }
                    }
                    else if (matrix[playersRow, playersCol] == 'T')
                    {
                        if (command == "up")
                        {
                            playersRow++;
                        }
                        else if (command == "down")
                        {
                            playersRow--;
                        }
                        else if (command == "left")
                        {
                            playersCol++;
                        }
                        else if (command == "right")
                        {
                            playersCol--;
                        }
                    }

                }

                if (IsItOutOfTheMatrix(matrix, playersRow, playersCol))
                {
                    if (playersRow < 0)
                    {
                        playersRow = matrix.GetLength(0) - 1;
                    }
                    else if (playersRow >= matrix.GetLength(0))
                    {
                        playersRow = 0;
                    }
                    else if (playersCol < 0)
                    {
                        playersCol = matrix.GetLength(1) - 1;
                    }
                    else if (playersCol >= matrix.GetLength(1))
                    {
                        playersCol = 0;
                    }
                }


                if (matrix[playersRow, playersCol] == 'F')
                {

                    matrix[playersRow, playersCol] = 'f';

                    Console.WriteLine("Player won!");
                    Print(matrix);
                    return;
                }

                matrix[playersRow, playersCol] = 'f';
            }

            Console.WriteLine("Player lost!");
            Print(matrix);
        }

        private static void CreateMatrix(ref int playersRow, ref int playersCol, char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string rowValue = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowValue[col];

                    if (matrix[row, col] == 'f')
                    {
                        playersRow = row;
                        playersCol = col;
                    }
                }
            }
        }


        static void Print(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }


        static bool IsItOutOfTheMatrix(char[,] matric, int playersRow, int playersCol)
        {
            if (playersRow < 0 || playersCol < 0 || playersRow >= matric.GetLength(0) || playersCol >= matric.GetLength(1))
            {
                return true;
            }

            return false;
        }
    }
}
