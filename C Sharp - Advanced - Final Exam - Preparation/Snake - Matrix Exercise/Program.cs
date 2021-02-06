using System;

namespace C_Sharp___Advanced___Exam_Prep
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int snakePositionRow = -1;
            int snakePositionCol = -1;
            int firstBurrowRow = -1;
            int firstBurrowCol = -1;
            int secondBurrowRow = -1;
            int secondBurrowCol = -1;


            int foodCount = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string rowsValue = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    matrix[row, col] = rowsValue[col];

                    if (matrix[row, col] == 'S')
                    {
                        snakePositionRow = row;
                        snakePositionCol = col;

                       

                    }

                    if(matrix[row, col] == 'B')
                    {
                        if (firstBurrowRow == -1)
                        {
                            firstBurrowRow = row;
                            firstBurrowCol = col;
                        }
                        else
                        {
                            secondBurrowRow = row;
                            secondBurrowCol = col;
                        }
                    }
                }
            }


            while (true)
            {

                if (foodCount >= 10)
                {

                    matrix[snakePositionRow, snakePositionCol] = 'S';
                    Console.WriteLine("You won! You fed the snake.");
                    break;
                }


               
                matrix[snakePositionRow, snakePositionCol] = '.';

                string command = Console.ReadLine();

                if (command == "up")
                {
                    
                    snakePositionRow--;
     
                }
                else if (command == "down")
                {

                    snakePositionRow++;


                }
                else if (command == "left")
                {
                    snakePositionCol--;


                }
                else if (command == "right")
                {
                    snakePositionCol++;


                }

                if (IsOutsideOfTheTerritory(matrix, snakePositionRow, snakePositionCol))
                {
                    Console.WriteLine("Game Over");
                    break;
                
                }

                if (matrix[snakePositionRow, snakePositionCol] == '*')
                {
                    foodCount++;
                }

                if (snakePositionRow == firstBurrowRow && snakePositionCol == firstBurrowCol)
                {
                    matrix[snakePositionRow, snakePositionCol] = '.';
                    snakePositionRow = secondBurrowRow;
                    snakePositionCol = secondBurrowCol;

                }
                else if (snakePositionRow == secondBurrowRow && snakePositionCol == secondBurrowCol)
                {
                    snakePositionRow = firstBurrowRow;
                    snakePositionCol = firstBurrowCol;
                }

                    matrix[snakePositionRow, snakePositionCol] = 'S';

               

                Print(matrix);

            }

            Console.WriteLine($"Food Eaten: {foodCount}");
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

        static bool IsOutsideOfTheTerritory(char[,] matrix, int snakeRow, int snakeCol)
        {

            if (snakeRow < 0 || snakeCol < 0 || snakeRow >= matrix.GetLength(0) || snakeCol >= matrix.GetLength(1))
            {
                return true;
            }

            return false;
        }

    }
}
