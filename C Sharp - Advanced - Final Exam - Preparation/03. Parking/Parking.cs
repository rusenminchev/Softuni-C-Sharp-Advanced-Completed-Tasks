using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private HashSet<Car> cars;

        public Parking(string type, int capacity)
        {
            this.cars = new HashSet<Car>();

            this.Type = type;
            this.Capacity = capacity;
        }

        public string Type { get; private set; }
        public int Capacity { get; private set; }
        public int Count => this.cars.Count;

        public void Add(Car car)
        {
            if (this.Count < this.Capacity)
            {
                this.cars.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            Car car = this.cars.FirstOrDefault
                (c => c.Manufacturer == manufacturer && c.Model == model);

            if (car == null)
            {
                return false;
            }

            this.cars.Remove(car);
            return true;
        }

        public Car GetLatestCar()
        {
            var latestCar = this.cars
                .FirstOrDefault(c => c.Year == this.cars.Max(c => c.Year));

            return latestCar;
        }

        public Car GetCar(string manufacturer, string model)
        {
            Car car = this.cars.FirstOrDefault
                (c => c.Manufacturer == manufacturer && c.Model == model);

            return car;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"The cars are parked in {this.Type}:");
           
            foreach (var car in this.cars)
            {
                sb.AppendLine(car.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
