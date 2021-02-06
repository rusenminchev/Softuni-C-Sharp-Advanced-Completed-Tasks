using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Lootbox___C_Sharp_Advanced_Exam___22_Feb_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstLootBox = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] secondLootBox = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> firstLootBoxQueue = new Queue<int>(firstLootBox);
            Stack<int> secondLootBoxStack = new Stack<int>(secondLootBox);

            List<int> claimedItems = new List<int>();

            while (firstLootBoxQueue.Count != 0 && secondLootBoxStack.Count != 0)
            {

                int currentFirstItem = firstLootBoxQueue.Peek();
                int currentSecondItem = secondLootBoxStack.Peek();
                int currentItemsSum = currentFirstItem + currentSecondItem;

                if (currentItemsSum % 2 == 0)
                {
                    claimedItems.Add(currentItemsSum);
                    firstLootBoxQueue.Dequeue();
                    secondLootBoxStack.Pop();

                }
                else
                {
                    currentSecondItem = secondLootBoxStack.Pop();
                    firstLootBoxQueue.Enqueue(currentSecondItem);
                }
            }

            if (firstLootBoxQueue.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else if (secondLootBoxStack.Count == 0)
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (claimedItems.Sum() >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {claimedItems.Sum()}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {claimedItems.Sum()}");
            }
        }
    }
}
