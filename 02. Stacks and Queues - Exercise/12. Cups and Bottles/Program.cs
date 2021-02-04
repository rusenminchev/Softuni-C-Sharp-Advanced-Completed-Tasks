using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cups = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
     .Select(int.Parse).ToArray();
            int[] bottles = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            Stack<int> bottlesStack = new Stack<int>(bottles);
            Queue<int> cupsQueue = new Queue<int>(cups);

            int wastedWater = 0;

            while (cupsQueue.Count > 0)
            {
              
                    int currentBottle = bottlesStack.Pop();
                    int currentCup = cupsQueue.Peek();


                    if (currentBottle >= currentCup)
                    {
                        wastedWater += currentBottle - currentCup;
                        cupsQueue.Dequeue();
                    }
                    else
                    {
                        currentCup -= currentBottle;
                        while (currentCup > 0)
                        {
                            currentBottle = bottlesStack.Pop();
                            currentCup -= currentBottle;
                            if (currentCup < 0)
                            {
                                wastedWater += Math.Abs(currentCup);
                            }
                        }
                        cupsQueue.Dequeue();
                    }

                if (bottlesStack.Count == 0)
                {
                    break;
                }
                
            }

            if (cupsQueue.Count == 0)
            {
                Console.WriteLine($"Bottles: {String.Join(' ', bottlesStack)}");
            }
            else
            {
                Console.WriteLine($"Cups: {String.Join(' ', cupsQueue)}");
            }


            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    
    }
}
