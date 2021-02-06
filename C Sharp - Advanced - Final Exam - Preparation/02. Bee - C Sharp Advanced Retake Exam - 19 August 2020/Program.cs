using System;

namespace _02._Bee___C_Sharp_Advanced_Retake_Exam___19_August_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n,n];

            int polinationedFlowers = 0;

            int currentIndexRow = 0;
            int currentIndexCol = 0;

            for (int rows = 0; rows < n; rows++)
            {
                string input = Console.ReadLine();

                for (int cols = 0; cols < n; cols++)
                {
                    matrix[rows, cols] = input[cols];
                    if (matrix[rows, cols] == 'B')
                    {
                        currentIndexRow = rows;
                        currentIndexCol = cols;
                    }
                }
            }

            string command = Console.ReadLine();


            while (command != "End")
            {


                if (command == "up")
                {
                    if (currentIndexRow - 1 < 0 || currentIndexRow - 1 >= n
                        || currentIndexCol < 0 || currentIndexCol >= n)
                    {
                        Console.WriteLine("The bee got lost!");
                        break;
                    }

                    if (matrix[currentIndexRow - 1, currentIndexCol] == 'f')
                    {
                        polinationedFlowers++;
                    }
                    else if (matrix[currentIndexRow - 1, currentIndexCol] == 'O')
                    {

                        matrix[currentIndexCol, currentIndexRow - 1] = matrix[currentIndexCol, currentIndexRow];
                        matrix[currentIndexCol, currentIndexRow] = '.';

                        currentIndexRow = currentIndexRow - 1;

                        if (matrix[currentIndexRow - 1, currentIndexCol] == 'f')
                        {
                            polinationedFlowers++;
                        }
                    }

                    matrix[currentIndexCol, currentIndexRow - 1] = matrix[currentIndexCol, currentIndexRow];
                    matrix[currentIndexCol, currentIndexRow] = '.';

                    currentIndexRow = currentIndexRow - 1;


                }
                else if (command == "down")
                {

                    if (currentIndexRow + 1 < 0 || currentIndexRow + 1 >= n
                        || currentIndexCol < 0 || currentIndexCol >= n)
                    {
                        Console.WriteLine("The bee got lost!");
                        break;
                    }

                    if (matrix[currentIndexRow + 1, currentIndexCol] == 'f')
                    {
                        polinationedFlowers++;
                    }
                    else if (matrix[currentIndexRow + 1, currentIndexCol] == 'O')
                    {

                        matrix[currentIndexCol, currentIndexRow + 1] = matrix[currentIndexCol, currentIndexRow];
                        matrix[currentIndexCol, currentIndexRow] = '.';

                        currentIndexRow = currentIndexRow + 1;

                        if (matrix[currentIndexRow + 1, currentIndexCol] == 'f')
                        {
                            polinationedFlowers++;
                        }
                    }

                    matrix[currentIndexCol, currentIndexRow + 1] = matrix[currentIndexCol, currentIndexRow];
                    matrix[currentIndexCol, currentIndexRow] = '.';

                    currentIndexRow = currentIndexRow + 1;

                  

                }
                else if (command == "left")
                {

                    if (currentIndexRow < 0 || currentIndexRow >= n
                        || currentIndexCol - 1 < 0 || currentIndexCol - 1 >= n)
                    {
                        Console.WriteLine("The bee got lost!");
                        break;
                    }


                    if (matrix[currentIndexRow, currentIndexCol - 1] == 'f')
                    {
                        polinationedFlowers++;
                    }
                    if (matrix[currentIndexCol - 1,currentIndexRow] == 'f')
                    {
                        polinationedFlowers++;
                    }
                    else if (matrix[currentIndexRow, currentIndexCol - 1] == 'O')
                    {

                        matrix[currentIndexCol - 1, currentIndexRow] = matrix[currentIndexCol, currentIndexRow];
                        matrix[currentIndexCol, currentIndexRow] = '.';

                        currentIndexCol = currentIndexCol - 1;

                        if (matrix[currentIndexRow, currentIndexCol - 1] == 'f')
                        {
                            polinationedFlowers++;
                        }
                    }

                    matrix[currentIndexCol - 1, currentIndexRow] = matrix[currentIndexCol, currentIndexRow];
                    matrix[currentIndexCol, currentIndexRow] = '.';

                    currentIndexCol = currentIndexCol - 1;

                   

                }
                else if (command == "right")
                {

                    if (currentIndexRow < 0 || currentIndexRow >= n
                        || currentIndexCol + 1 < 0 || currentIndexCol + 1 >= n)
                    {
                        Console.WriteLine("The bee got lost!");
                        break;
                    }

                    if (matrix[currentIndexRow, currentIndexCol + 1] == 'f')
                    {
                        polinationedFlowers++;
                    }
                    else if (matrix[currentIndexRow, currentIndexCol + 1] == 'O')
                    {

                        matrix[currentIndexCol + 1, currentIndexRow] = matrix[currentIndexCol, currentIndexRow];
                        matrix[currentIndexCol, currentIndexRow] = '.';

                        currentIndexCol = currentIndexCol + 1;

                        if (matrix[currentIndexRow, currentIndexCol + 1] == 'f')
                        {
                            polinationedFlowers++;
                        }
                    }

                    matrix[currentIndexCol + 1, currentIndexRow] = matrix[currentIndexCol, currentIndexRow];
                    matrix[currentIndexCol, currentIndexRow] = '.';

                    currentIndexCol = currentIndexCol + 1;
                }

                for (int rows = 0; rows < n; rows++)
                {
                    for (int cols = 0; cols < n; cols++)
                    {
                        Console.Write(matrix[rows, cols]);
                    }
                    Console.WriteLine();
                }

                command = Console.ReadLine();
            }


            if (polinationedFlowers >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {polinationedFlowers} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - polinationedFlowers} flowers more");
            }


          
        }
    }
}
