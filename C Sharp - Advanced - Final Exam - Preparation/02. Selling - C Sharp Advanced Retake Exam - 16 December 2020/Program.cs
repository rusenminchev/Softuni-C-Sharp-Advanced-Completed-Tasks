using System;
using System.Runtime.InteropServices;

namespace _02._Selling___C_Sharp_Advanced_Retake_Exam___16_December_2020
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int currentRow = -1;
            int currentCol = -1;

            int firstPillarRow = -1;
            int firstPillarCol = -1;
            int secondPillarRow = -1;
            int secondPillarCol = -1;

            int earnedMoney = 0;


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string rowValue = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowValue[col];

                    if (matrix[row, col] == 'S')
                    {
                        currentRow = row;
                        currentCol = col;
                    }

                    if (matrix[row, col] == 'O')
                    {
                        if (firstPillarRow == -1)
                        {
                            firstPillarRow = row;
                            firstPillarCol = col;
                        }
                        else
                        {
                            secondPillarRow = row;
                            secondPillarCol = col;
                        }
                    }
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                matrix[currentRow, currentCol] = '-';

                if (command == "up")
                {
                    currentRow--;
                }
                else if (command == "down")
                {
                    currentRow++;
                }
                else if (command == "left")
                {
                    currentCol--;
                }
                else if (command == "right")
                {
                    currentCol++;
                }

                if (IsInTheBakery(matrix, currentRow, currentCol))
                {
                    if (char.IsDigit(matrix[currentRow,currentCol]))
                    {
                        int charToIntValue = (int)Char.GetNumericValue(matrix[currentRow, currentCol]);
                        earnedMoney += charToIntValue;
                    }

                    if (matrix[currentRow, currentCol] == 'O')
                    {
                        if (currentRow == firstPillarRow && currentCol == firstPillarCol)
                        {
                            matrix[currentRow, currentCol] = '-';
                            currentRow = secondPillarRow;
                            currentCol = secondPillarCol;
                        }
                        else if (currentRow == secondPillarRow && currentCol == secondPillarCol)
                        {
                            matrix[currentRow, currentCol] = '-';
                            currentRow = firstPillarRow;
                            currentCol = firstPillarCol;
                        }
                    }

                    matrix[currentRow, currentCol] = 'S';

                    if (earnedMoney >= 50)
                    {
                        Console.WriteLine("Good news! You succeeded in collecting enough money!");
                        break;
                    }   
                }
                else
                {
                    Console.WriteLine("Bad news, you are out of the bakery.");
                    break;
                }
            }

            Console.WriteLine($"Money: {earnedMoney}");
            Print(matrix);
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

        static bool IsInTheBakery(char[,] matrix, int currentRow, int currentCol)
        {
            if (currentRow >= 0 && currentRow < matrix.GetLength(0) && currentCol >= 0 && currentCol < matrix.GetLength(1))
            {
                return true;
            }
            return false;
        }
    }
}
