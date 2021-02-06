using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RawData
{
    public class Car
    {
        private List<Tire> tires;

        public Car()
        {

        }
        public Car(string model, Engine engine, Cargo cargo, List<Tire> tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.tires = tires;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }

        public List<Tire> Tires { get; set; }


    }
}
