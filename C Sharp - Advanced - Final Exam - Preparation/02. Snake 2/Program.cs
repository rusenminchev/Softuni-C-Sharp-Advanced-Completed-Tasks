using System;
using System.Runtime.CompilerServices;

namespace _02._Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int snakeRow = -1;
            int snakeCol = -1;

            int firstBurrowRow = -1;
            int firstBurrowCol = -1;
            int secondBurrowRow = -1;
            int secondBurrowCol = -1;

            int foodEatenCount = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];

                    if (matrix[row, col] == 'S')
                    {
                        snakeRow = row;
                        snakeCol = col;
                    }

                    if (matrix[row, col] == 'B')
                    {
                        if (firstBurrowRow == -1 && firstBurrowCol == -1)
                        {
                            firstBurrowRow = row;
                            firstBurrowCol = col;
                        }
                        else if (secondBurrowRow == -1 && secondBurrowCol == -1)
                        {
                            secondBurrowRow = row;
                            secondBurrowCol = col;
                        }
                    }
                }
            }

            string command;

            while ((command = Console.ReadLine()) != "end")
            {

                matrix[snakeRow, snakeCol] = '.';

                if (command == "up")
                {
                    snakeRow--;
                }
                else if (command == "down")
                {
                    snakeRow++;
                }
                else if (command == "left")
                {
                    snakeCol--;
                }
                else if (command == "right")
                {
                    snakeCol++;
                }

                if (IsInTheMatrix(matrix, snakeRow, snakeCol))
                {
                    if (matrix[snakeRow, snakeCol] == '*')
                    {
                        foodEatenCount++;

                        if (foodEatenCount == 10)
                        {
                            matrix[snakeRow, snakeCol] = 'S';
                            break;
                        }
                    }
                    else if (matrix[snakeRow, snakeCol] == 'B')
                    {
                        matrix[snakeRow, snakeCol] = '.';

                        if (snakeRow == firstBurrowRow && snakeCol == firstBurrowCol)
                        {
                            snakeRow = secondBurrowRow;
                            snakeCol = secondBurrowCol;
                        }
                        else if (snakeRow == secondBurrowRow && snakeCol == firstBurrowCol)
                        {
                            snakeRow = firstBurrowRow;
                            snakeCol = firstBurrowCol;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Game over!");
                    break;
                }

                matrix[snakeRow, snakeCol] = 'S';
            }

            if (foodEatenCount == 10)
            {
                Console.WriteLine("You won! You fed the snake.");
            }

            Console.WriteLine($"Food eaten: {foodEatenCount}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static bool IsInTheMatrix(char[,] matrix, int snakeRow, int snakeCol)
        {
            return snakeRow >= 0 && snakeRow < matrix.GetLength(0) &&
                   snakeCol >= 0 && snakeCol < matrix.GetLength(1);
        }
    }
}
