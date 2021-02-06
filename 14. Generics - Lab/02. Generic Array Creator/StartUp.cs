using System;
using System.Threading;

namespace GenericArrayCreator
{
    class StartUp
    {
        static void Main(string[] args)
        {

            string[] stringArray = ArrayCreator.Create(5, "Rusen");
            int[] intArray = ArrayCreator.Create(5, 50);
            int count = 1;

            foreach (var item in stringArray)
            {

                Console.WriteLine($"{count++}. {item}");

            }

            count = 1;

            foreach (var item in intArray)
            {

                Console.WriteLine($"{count++}. {item}");

            }

        }
    }
}
