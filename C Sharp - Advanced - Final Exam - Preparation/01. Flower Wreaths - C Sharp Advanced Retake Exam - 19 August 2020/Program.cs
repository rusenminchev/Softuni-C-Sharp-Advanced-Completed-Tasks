using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Flower_Wreaths___C_Sharp_Advanced_Retake_Exam___19_August_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lilies = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] roses = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> liliesStack = new Stack<int>(lilies);
            Queue<int> rosesQueue = new Queue<int>(roses);

            int wreathsCounter = 0;
            int storedFlowersForLater = 0;

            while (liliesStack.Count != 0 && rosesQueue.Count != 0)
            {

                int currentLilie = liliesStack.Pop();
                int currentRose = rosesQueue.Dequeue();
                int currentSum = currentLilie + currentRose;
    
                if (currentSum > 15)
                {
                    while (currentSum > 15)
                    {
                        currentSum -= 2;
                    }
                }
                if(currentSum == 15)
                {
                    wreathsCounter++;
                }
                else if (currentSum < 15)
                {
                    storedFlowersForLater += currentSum;
                }
            }

            wreathsCounter += (storedFlowersForLater / 15);

            if (wreathsCounter >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreathsCounter} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreathsCounter} wreaths more!");
            }         
        }
    }
}
