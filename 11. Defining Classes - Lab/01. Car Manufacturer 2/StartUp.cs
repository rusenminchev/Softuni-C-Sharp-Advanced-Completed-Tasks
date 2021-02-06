using System;

namespace CarManufacturer2
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            //car.Make = "VW";
            //car.Model = "MK3";
            //car.Year = 1992;
            //car.FuelQuantity = 200;
            //car.FuelConsumption = 15;
            //car.Drive(10);
            Console.Write(car.GetSpecifications());

            var engine = new Engine(116, 2.0);
            var hp = engine.HorsePower;
            var cubicCapacity = engine.CubicCapacity;

            var tyres = new Tyre(2020, 3.0);
            var tyreYear = tyres.Year;
            var tyrePressure = tyres.Pressure;
            
          
            Console.WriteLine($"Brand:{car.Make} - Model:{car.Model} - Year of production:{car.Year} - Fuel capacity:{car.FuelQuantity}" +
                $" - Fuel consumtion:{car.FuelConsumption}\nEngine: HP:{hp} CB:{cubicCapacity:f2} - Tyres: Year:{tyreYear} Pressure:{tyrePressure:f2}");




        }
    }
}
