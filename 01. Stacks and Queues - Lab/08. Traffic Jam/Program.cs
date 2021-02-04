using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCarsThatCanPass = int.Parse(Console.ReadLine());
            Queue<string> traficQueue = new Queue<string>();

            string carOrCommand = Console.ReadLine();
            int counter = 0;

            while (carOrCommand != "end")
            {
                if (carOrCommand == "green")
                {
                    for (int i = 0; i < numberOfCarsThatCanPass; i++)
                    {
                        if (traficQueue.Any())
                        {
                            string currentCar = traficQueue.Dequeue();
                            Console.WriteLine(currentCar + " passed!");
                            counter++;
                        } 
                    }        
                }
                else
                {
                    traficQueue.Enqueue(carOrCommand);
                }
                carOrCommand = Console.ReadLine();
            }

            Console.WriteLine(counter + " cars passed the crossroads.");

        }
    }
}
