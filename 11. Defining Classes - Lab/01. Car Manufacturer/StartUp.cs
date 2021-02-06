using System;

namespace CarManufacturer
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
            //car.FuelConsumption = 10;
            //car.Drive(200);

            Console.WriteLine(car.GetSpecifications());



        }
    }  
}
