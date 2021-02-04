using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            short quantityForToday = short.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> ordersQueue = new Queue<int>(orders);

            int biggest = int.MinValue;
            bool isThereOrdersLeft = false;

            if (ordersQueue.Any())
            {
                for (int i = 0; i < ordersQueue.Count; i++)
                {
                    int currentOrder = ordersQueue.Dequeue();

                    if (biggest < currentOrder)
                    {
                        biggest = currentOrder;
                    }

                    ordersQueue.Enqueue(currentOrder);
                }

                Console.WriteLine(biggest);

                

                for (int i = 0; i < ordersQueue.Count; i++)
                {
                    int currentOrder = ordersQueue.Peek();

                    if (quantityForToday - currentOrder >= 0)
                    {
                        quantityForToday -= (short)currentOrder;
                        ordersQueue.Dequeue();
                        i--;
                    }
                    else
                    {
                        isThereOrdersLeft = true;
                    }

                }
            }

            if (isThereOrdersLeft)
            {
                Console.WriteLine("Orders left: " + String.Join(' ', ordersQueue));

            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
