using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            int numberOfTosses = int.Parse(Console.ReadLine());

            Queue<string> kids = new Queue<string>(names);

            int currentIndex = 1;
            // MIMI PEPI TOSHKO

            while (kids.Count > 1)
            {
                string currentKid = kids.Dequeue();

                if (currentIndex == numberOfTosses)
                {
                    Console.WriteLine("Removed " + currentKid);
                    currentIndex = 0;
                }   
                else
                {
                    kids.Enqueue(currentKid);
                }
                currentIndex++;
            }

            Console.WriteLine("Last is " + kids.Dequeue());
        }
    }
}
