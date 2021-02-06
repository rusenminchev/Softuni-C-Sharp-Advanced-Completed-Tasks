using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        public Car()
        {

        }
        public Car(string model, double fuelAmount, double fuelConsuptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsuptionPerKilometer = fuelConsuptionPerKilometer;
            this.TraveledDistance = 0;

        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsuptionPerKilometer { get; set; }
        public double TraveledDistance { get; set; }
        
        // Като променливи за извикване на метода подаваме само нужните променливи, които са извън класа. За тези, които
        // са вътре извикваме пропъртитата на класа.

        public bool Drive(double fuelNeeded)
        { 
            if (this.FuelAmount - fuelNeeded >= 0)
            {
                return true;
            }
            return false;

        }
    }
}
