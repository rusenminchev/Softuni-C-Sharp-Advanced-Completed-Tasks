using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tasksInput = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] threadsInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int taskToKill = int.Parse(Console.ReadLine());

            Stack<int> tasks = new Stack<int>(tasksInput);
            Queue<int> threads = new Queue<int>(threadsInput);

            while (true)
            {
                int currentThread = threads.Peek();
                int currentTask = tasks.Peek();

                if (currentTask == taskToKill)
                {
                    Console.WriteLine($"Thread with value {currentThread} killed task {currentTask}");
                    break;
                }

                if (currentThread >= currentTask)
                {
                    threads.Dequeue();
                    tasks.Pop();
                }
                else if (currentThread < currentTask)
                {
                    threads.Dequeue();
                }
            }

            Console.WriteLine(string.Join(' ',threads));

        }
    }
}
