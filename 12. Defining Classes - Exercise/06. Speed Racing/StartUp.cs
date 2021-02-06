using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                   .ToArray();
                string model = carArgs[0];
                double fuelAmount = double.Parse(carArgs[1]);
                double fuelConsumptionPerKilometer = double.Parse(carArgs[2]);

                cars.Add(model, new Car(model, fuelAmount, fuelConsumptionPerKilometer));
            }


            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string model = cmdArgs[1];
                double amountOfKm = double.Parse(cmdArgs[2]);
                double fuelNeeded = cars[model].FuelConsuptionPerKilometer * amountOfKm;


                if (cars[model].Drive(fuelNeeded))
                {
                    cars[model].FuelAmount -= fuelNeeded;
                    cars[model].TraveledDistance += amountOfKm;
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }

            }

            foreach (var (car, Car) in cars)
            {
                Console.WriteLine($"{Car.Model} {Car.FuelAmount:f2} {Car.TraveledDistance}");
            }
        }
    }
}
