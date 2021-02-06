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

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                   .ToArray();
                string model = carArgs[0];
                double fuelAmount = double.Parse(carArgs[1]);
                double fuelConsumptionPerKilometer = double.Parse(carArgs[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionPerKilometer);
                cars.Add(car);
            }

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string model = cmdArgs[1];
                double amountOfKm = double.Parse(cmdArgs[2]);

                Car car = cars.FirstOrDefault(x => x.Model == model);

                car.Drive(amountOfKm);

            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TraveledDistance}");
            }
        }
        // С този метод можем да вземем елемент, който ни трябва от колекция, като ли List<>, HarshSet<> и т.н.
        // Работи по същия начин, като експрешъна горе -> Car car = cars.FirstOrDefault(x => x.Model == model);
        // Или може и чрез Dictionary, както Аз реших задачата първоначално.
        //static Car GetTheCurrentCar(List<Car> cars, string model)
        //{
        //    foreach (var car in cars)
        //    {
        //        if (car.Model == model)
        //        {
        //            return car;
        //        }
               
        //    }
        //    return null;
        //}
    }
}
