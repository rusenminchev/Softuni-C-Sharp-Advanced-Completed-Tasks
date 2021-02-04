using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem_10.__Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());


            Queue<string> trafficQueue = new Queue<string>();
            int counter = 0;

            string command = Console.ReadLine();

            while (command != "END")
            {
                if (command == "green")
                {
                    if (trafficQueue.Any())
                    {
                        string currentCar = trafficQueue.Dequeue();
                        string lastCar = currentCar;
                        for (int i = 0; i < greenLightDuration; i++)
                        {
                            if (currentCar.Length > 0)
                            {
                                currentCar = currentCar.Remove(0, 1);
                            }
                            else
                            {
                                if (trafficQueue.Any())
                                {

                                    currentCar = trafficQueue.Dequeue();
                                    counter++;
                                    lastCar = currentCar;
                                    currentCar = currentCar.Remove(0, 1);


                                }
                            }
                        }

                        for (int i = 0; i < freeWindow; i++)
                        {
                            if (currentCar.Length > 0)
                            {
                                currentCar = currentCar.Remove(0, 1);
                            }
                            else
                            {
                                break;
                            }

                        }

                        if (currentCar.Length > 0)
                        {
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine(lastCar + " was hit at " + currentCar[0] + ".");
                            return;
                        }
                        else
                        {
                            counter++;
                        }
                    }
                }
                else
                {
                    trafficQueue.Enqueue(command);
                }

                command = Console.ReadLine();

            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{counter} total cars passed the crossroads.");
        }
    }
}
