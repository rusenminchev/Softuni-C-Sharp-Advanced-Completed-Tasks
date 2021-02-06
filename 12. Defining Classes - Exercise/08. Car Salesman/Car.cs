using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }
        public Car(string model, Engine engine, int weight)
            : this(model, engine)
        {
            this.Weight = weight;
        }
        public Car(string model, Engine engine, string color)
            : this(model, engine)
        {
            this.Color = color;
        }
        public Car(string model, Engine engine, int weight, string color)
            : this(model, engine)
        {
            this.Weight = weight;
            this.Color = color;
        }


        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int? Weight { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            string weightString = this.Weight.HasValue ?
                this.Weight.ToString() : "n/a";

            string colorString = String.IsNullOrEmpty(this.Color) ? "n/a" : this.Color;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Model}:")
                .AppendLine($"  {this.Engine}")     
                .AppendLine($"  Weight: {weightString}")
                .AppendLine($"  Color: {colorString}");

            return sb.ToString().TrimEnd();
        }
    }
}
