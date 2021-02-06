﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
   public class Car
    {
        public Car(string make, string model, int horsePower, string registrationNumber)
        {
            this.Make = make;
            this.Model = model;
            this.HorsePower = horsePower;
            this.RegistrationNumber = registrationNumber;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string RegistrationNumber { get; set; }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Make: {Make}")
            .AppendLine($"Model: {Model}")
            .AppendLine($"HorsePower: {HorsePower}")
            .AppendLine($"RegistrationNumber: {RegistrationNumber}");

            return sb.ToString().TrimEnd();

        }
    }
}
