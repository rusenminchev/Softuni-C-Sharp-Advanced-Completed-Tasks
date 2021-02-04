using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            
            HashSet<string> cars = new HashSet<string>();

            while (input[0] != "END")
            {
                string direction = input[0];
                string carNumber = input[1];

                if (direction == "IN")
                {
                    cars.Add(carNumber);
                }
                if (direction == "OUT")
                {
                    cars.Remove(carNumber);
                }

                input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }
            if (cars.Any())
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
