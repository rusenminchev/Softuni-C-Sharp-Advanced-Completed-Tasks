using System;
using System.Collections.Generic;
using System.Linq;

namespace The_Fight_for_Gondor
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfWaves = int.Parse(Console.ReadLine());

            int[] defenceInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> defence = new Queue<int>(defenceInput);
            Stack<int> orcsWarriors = new Stack<int>();

            for (int i = 1; i <= numberOfWaves; i++)
            {
                int[] orcsInput = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                orcsWarriors = new Stack<int>(orcsInput);

                if (i % 3 == 0)
                {
                    int extraDefence = int.Parse(Console.ReadLine());
                    defence.Enqueue(extraDefence);
                }

                while (defence.Any() && orcsWarriors.Any())
                {
                    int currentPlate = defence.Peek();
                    int currentOrc = orcsWarriors.Pop();

                    if (currentOrc > currentPlate)
                    {
                        currentOrc -= currentPlate;
                        defence.Dequeue();

                        orcsWarriors.Push(currentOrc);
                    }
                    else if (currentOrc < currentPlate)
                    {
                        defence.Dequeue();
                        currentPlate -= currentOrc;

                        PlaceCurrentPlateOnFirstPosition(defence, currentPlate);
                    }
                    else if (currentOrc == currentPlate)
                    {
                        defence.Dequeue();
                    }
                }

                if (defence.Count == 0)
                {
                    break;
                }
            }

            if (defence.Count > 0)
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.WriteLine("Plates left: " + string.Join(", ", defence));
            }
            else
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine("Orcs left: " + string.Join(", ", orcsWarriors));
            }
        }

        private static void PlaceCurrentPlateOnFirstPosition(Queue<int> defence, int currentPlate)
        {
            List<int> list = new List<int>(defence);
            defence.Clear();
            defence.Enqueue(currentPlate);

            for (int j = 0; j < list.Count; j++)
            {
                defence.Enqueue(list[j]);
            }
        }
    }
}
