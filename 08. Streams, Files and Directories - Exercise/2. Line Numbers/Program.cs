using System;
using System.IO;

namespace _2._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using StreamReader reader = new StreamReader("TextFile1.txt");
            using StreamWriter writer = new StreamWriter("Output.txt", true);

            int counter = 1;

            while (true)
            {
                string line = reader.ReadLine();

                if (line == null)
                {
                    break;
                }

                // записване във файла
                writer.WriteLine($"{counter}. {line}");

                // принтиране на конзолата
                Console.WriteLine($"{counter}. {line}");
                counter++;

                

            }
        }
    }
}
