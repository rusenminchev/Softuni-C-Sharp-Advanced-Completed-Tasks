using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bombEffectsInput = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] bombCasingsInput = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> bombEffects = new Queue<int>(bombEffectsInput);
            Stack<int> bombCasings = new Stack<int>(bombCasingsInput);

            Dictionary<string, int> producedBombs = new Dictionary<string, int>()
            {
                ["Datura Bombs"] = 0,
                ["Cherry Bombs"] = 0,
                ["Smoke Decoy Bombs"] = 0,
            };

            bool isBombPouchFull = false;

            while (bombEffects.Any() && bombCasings.Any())
            {
                int currentBombFx = bombEffects.Peek();
                int currentBombCasing = bombCasings.Pop();

                if (currentBombCasing + currentBombFx == 40)
                {
                    producedBombs["Datura Bombs"]+=1;
                    bombEffects.Dequeue();
                }
                else if (currentBombCasing + currentBombFx == 60)
                {
                    producedBombs["Cherry Bombs"]+=1;
                    bombEffects.Dequeue();
                }
                else if (currentBombCasing + currentBombFx == 120)
                {
                    producedBombs["Smoke Decoy Bombs"]+=1;
                    bombEffects.Dequeue();
                }
                else
                {
                    currentBombCasing -= 5;
                    bombCasings.Push(currentBombCasing);
                }

                isBombPouchFull = producedBombs.All(b => b.Value >= 3);

                if (isBombPouchFull)
                {
                    Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
                    break;
                }
            }

            if (!isBombPouchFull)
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (bombEffects.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine("Bomb Effects: " + string.Join(", ", bombEffects));
            }

            if (bombCasings.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine("Bomb Casings: " + string.Join(", ", bombCasings));
            }

            foreach (var bomb in producedBombs.OrderBy(c=>c.Key))
            {
                Console.WriteLine($"{bomb.Key}: {bomb.Value}");
            }
        }
    }
}
