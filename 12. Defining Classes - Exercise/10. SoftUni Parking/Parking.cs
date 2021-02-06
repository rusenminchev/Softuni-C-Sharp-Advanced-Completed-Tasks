using SoftUniParking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
        List<Car> cars;
        int capacity;
        int count;

        public Parking(int capacity)
        {
            this.cars = new List<Car>();
            this.capacity = capacity;
        }

        public int Count
        {
            get
            {
               return this.count = cars.Count;
            }
        }

        public string AddCar(Car car)
        {
            if (cars.Any(x => x.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }

            if (cars.Count == capacity)
            {
                return "Parking is full!";
            }

            cars.Add(car);
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }

        public string RemoveCar(string regNumber)
        {

            if (!cars.Any(x => x.RegistrationNumber == regNumber))
            {
                return "Car with that registration number, doesn't exist!";
            }

            Car currentCar = cars.FirstOrDefault(x => x.RegistrationNumber == regNumber);

            cars.Remove(currentCar);

            return $"Successfully removed {regNumber}";
        }

        public Car GetCar(string regNumber)
        {
            Car currentCar = cars.FirstOrDefault(x => x.RegistrationNumber == regNumber);
            return currentCar;
        }

        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {

            foreach (var number in RegistrationNumbers)
            {
                Car currentCar = cars.FirstOrDefault(x => x.RegistrationNumber == number);
                if (cars.Contains(currentCar))
                {
                    Console.WriteLine(currentCar);
                    cars.Remove(currentCar);        
                }
            }
        }
    }
}
