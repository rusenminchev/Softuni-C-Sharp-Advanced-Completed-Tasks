using System;
using System.Collections.Generic;
using System.Linq;

namespace Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] clothesInTheBox = Console.ReadLine().Split().Select(byte.Parse).ToArray();

            Stack<byte> clothesValue = new Stack<byte>(clothesInTheBox);

            byte racsCapacity = byte.Parse(Console.ReadLine());

            int sum = 0;
            int racsCounter = 1;

            while (clothesValue.Count > 0)
            {

                sum += clothesValue.Peek();

                if (racsCapacity >= sum)
                {
                    clothesValue.Pop();
                }
                else
                {
                    racsCounter++;
                    sum = 0;
                }
            }

            Console.WriteLine(racsCounter);

        }
    }
}
