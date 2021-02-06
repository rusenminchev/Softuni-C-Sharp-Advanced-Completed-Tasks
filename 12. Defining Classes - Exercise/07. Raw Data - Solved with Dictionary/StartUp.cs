using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace RawData
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
                int engineSpeed = int.Parse(carArgs[1]);
                int enginePower = int.Parse(carArgs[2]);
                int cargoWeight = int.Parse(carArgs[3]);
                string cargoType = carArgs[4];

                List<Tire> tires = new List<Tire>();

                for (int j = 5; j < carArgs.Length; j += 2)
                {

                    double tirePressure = double.Parse(carArgs[j]);
                    int tireAge = int.Parse(carArgs[j+1]);
                    Tire currentTire = new Tire(tirePressure, tireAge);

                    tires.Add(currentTire);
                }


                Car car = new Car(model,
                    new Engine(engineSpeed, enginePower),
                    new Cargo(cargoWeight, cargoType),
                    tires);

                cars.Add(model, car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                cars.Where(x => x.Value.Cargo.CargoType == "fragile");

                foreach (var (car,Car) in cars)
                {
                    foreach (var tire in Car.Tires)
                    {
                        if (tire.TirePressure < 1)
                        {
                            Console.WriteLine(car);
                            break;
                        }
                    } 
                }  
            }
            else if (command == "flamable")
            {
                cars.Where(x => x.Value.Cargo.CargoType == "flamable");

                foreach (var car in cars)

                        if (car.Value.Engine.EnginePower > 250)
                        {
                            Console.WriteLine(car.Key);
                        }
            }
        }
    }
}