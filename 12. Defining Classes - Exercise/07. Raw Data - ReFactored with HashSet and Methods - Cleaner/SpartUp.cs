using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<Car> cars = new HashSet<Car>();


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
                GetTires(carArgs, tires);
                Engine engine = CreateNewEngine(engineSpeed, enginePower);
                Cargo cargo = CreateNewCargo(cargoWeight, cargoType);

                Car car = new Car(model, engine, cargo,tires);

                cars.Add(car);
            }

            string command = Console.ReadLine();
            HashSet<Car> result = new HashSet<Car>();

            if (command == "fragile")
            {
                result = cars.Where(c => c.Cargo.CargoType == "fragile" &&
                c.Tires.Any(t => t.TirePressure < 1)).ToHashSet();
                  
            }
            else if (command == "flamable")
            {
              result = cars.Where(c => c.Cargo.CargoType == "flamable" &&
                    c.Engine.EnginePower > 250).ToHashSet();
            }

            foreach (var car in result)
            {
                Console.WriteLine(car.Model);
            }

        }

        private static Engine CreateNewEngine(int engineSpeed, int enginePower)
        {
            return new Engine(engineSpeed, enginePower);
        }

        private static Cargo CreateNewCargo(int cargoWeight, string cargoType)
        {
            return new Cargo(cargoWeight, cargoType);
        }

        private static void GetTires(string[] carArgs, List<Tire> tires)
        {
            for (int j = 5; j < carArgs.Length; j += 2)
            {

                double tirePressure = double.Parse(carArgs[j]);
                int tireAge = int.Parse(carArgs[j + 1]);
                Tire currentTire = new Tire(tirePressure, tireAge);

                tires.Add(currentTire);
            }
        }
    }
}