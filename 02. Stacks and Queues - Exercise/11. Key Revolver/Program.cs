using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace Problem_11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int GunBarrelSize = int.Parse(Console.ReadLine());

            int firedBulletsCount = 0;

            int[] bullets = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int[] locks = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int valueOfIntel = int.Parse(Console.ReadLine());

            Stack<int> bulletsStack = new Stack<int>(bullets);
            Queue<int> locksQueue = new Queue<int>(locks);

            while (locksQueue.Count > 0)
            {

                int currentShot = bulletsStack.Pop();
                firedBulletsCount++;
                valueOfIntel -= bulletPrice;

                if (locksQueue.Any())
                {
                    if (currentShot <= locksQueue.Peek())
                    {         
                            locksQueue.Dequeue();
                            Console.WriteLine("Bang!");
                    }
                    else
                    {
                        Console.WriteLine("Ping!");
                    }

                    if (bulletsStack.Count == 0)
                    {
                        break;
                    }

                    if (firedBulletsCount == GunBarrelSize)
                    {
                        Console.WriteLine("Reloading!");
                        firedBulletsCount = 0;
                    }
                }
            }

            if (locksQueue.Count > 0)
            {

                Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");

            }
            else
            {
                Console.WriteLine($"{bulletsStack.Count} bullets left. Earned ${valueOfIntel}");
            
            }
        }
    }
}
