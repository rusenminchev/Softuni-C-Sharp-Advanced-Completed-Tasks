using System;
using System.IO;

namespace _1._Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            using StreamReader reader = new StreamReader("TextFile1.txt");
            int counter = 0;


            while (true)
            {
               string line = reader.ReadLine();

                if (line == null)
                {
                    break;
                }

                if (counter % 2 == 1)
                {
                    Console.WriteLine(line);
                }
                counter++;
            }

        }
    }
}
