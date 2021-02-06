using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Cooking___C_Sharp_Advanced_Retake_Exam___16_December_2020
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] liquids = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] ingredients = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> liquidsQueue = new Queue<int>(liquids);
            Stack<int> ingredientsStack = new Stack<int>(ingredients);

            Dictionary<string, int> cookedFood = new Dictionary<string, int>();
            cookedFood.Add("Bread", 0);
            cookedFood.Add("Cake", 0);
            cookedFood.Add("Pastry", 0);
            cookedFood.Add("Fruit Pie", 0);

            bool isThereEnoughFood = true;

            while (liquidsQueue.Count != 0 && ingredientsStack.Count != 0)
            {
                int currentLiquid = liquidsQueue.Dequeue();
                int currentIngredient = ingredientsStack.Pop();
                int currentSum = currentLiquid + currentIngredient;
             
                if (currentSum == 25)
                {
                    cookedFood["Bread"]++;
                }
                else if (currentSum == 50)
                {
                    cookedFood["Cake"]++;
                   
                }
                else if (currentSum == 75)
                {
                    cookedFood["Pastry"]++;
                 
                }
                else if (currentSum == 100)
                {
                    cookedFood["Fruit Pie"]++;
                 
                }
                else
                {
                    currentIngredient += 3;
                    ingredientsStack.Push(currentIngredient);           
                }
            }

            foreach (var food in cookedFood)
            {
                if (food.Value == 0)
                {
                    isThereEnoughFood = false;
                }
            }

            if (isThereEnoughFood)
            {
                Console.WriteLine($"Wohoo! You succeeded in cooking all the food!");

            }
            else
            {
                Console.WriteLine($"Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (liquidsQueue.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.WriteLine($"Liquids left: " + string.Join(", ", liquidsQueue));
            }

            if (ingredientsStack.Count == 0)
            {
                Console.WriteLine("Ingredients left: none");
            }
            else
            {
                Console.WriteLine($"Ingredients left: " + string.Join(", ", ingredientsStack));
            }

            foreach (var food in cookedFood.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{food.Key}: {food.Value}");
            }
        }
    }
}
