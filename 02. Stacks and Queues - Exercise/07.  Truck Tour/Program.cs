using System;
using System.Collections.Generic;
using System.Linq;

namespace Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {

            int nPetrolPumps = int.Parse(Console.ReadLine());

            int counter = 0;

            Queue<int[]> petrolPumps = new Queue<int[]>();
            FillQueue(nPetrolPumps, petrolPumps);

            while (true)
            {
                int truckFuel = 0;
                bool rightPumpFound = true;

                for (int i = 0; i < nPetrolPumps; i++)
                {
                    int[] currentPump = petrolPumps.Dequeue();

                    truckFuel += currentPump[0];

                    if (truckFuel < currentPump[1])
                    {
                        rightPumpFound = false;
                    }

                    truckFuel -= currentPump[1];
                    petrolPumps.Enqueue(currentPump);
                }

                if (rightPumpFound)
                {
                    break;
                }

                counter++;

                petrolPumps.Enqueue(petrolPumps.Dequeue());
            }
            Console.WriteLine(counter);
        }

        private static void FillQueue(int nPetrolPumps, Queue<int[]> petrolPumps)
        {
            for (int i = 0; i < nPetrolPumps; i++)
            {
                int[] petrolPumpInfo = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToArray();
                petrolPumps.Enqueue(petrolPumpInfo);
            }
        }
    }
}
