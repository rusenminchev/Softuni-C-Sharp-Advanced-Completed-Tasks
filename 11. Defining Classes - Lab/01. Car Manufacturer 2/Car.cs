using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer2
{


    // след fields се пишат constructor-ите. В тях се инициализират нъжните променливи и там се застраховена, че стейста на
    // обекта ще е валиден

    public class Car
        {
            private int year;

        public Car()
            : this("VW", "Golf", 2025, 200, 10, new Engine(116, 2.0), new Tyre(2020, 3.0))
        //Така се задават default-ни на обект чрез конструктура
        {

        }

        public Car(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;

        }

        public Car(
            string make,
            string model, 
            int year, 
            double fuelQuantity, 
            double fuelConsumption)
            : this(make,model,year)
        // При преизползването на един конструктор от друг. Даваме на този, които преизползва вече добавените
        //промендливи в този от които преизползва и така не се налага да ги пишем в първия.
        {

            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public Car(
            string make, 
            string model, 
            int year, 
            double fuelQuantity, 
            double fuelConsumption, 
            Engine engine, 
            Tyre tyre)
          : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tyre = tyre;
        
        }



        // след конструкторите се пишат properties.
        // get подава пропъртите и така можем да го четем, а set променя неговата стойност.


        public string Make { get; set; }
        public string Model { get; set; }
            public int Year
            {
                get
                {
                    return this.year;
                }
                set
                {
                    if (value < 1989)
                    {
                        throw new InvalidOperationException("Year cannot be less than 1989");
                    }
                this.year = value;

                }
            }

        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public object Engine { get; }
        public object Tyre { get; set; }

        
        // След пропъртитата се пишат методите.

        public void Drive(double distance)
            {
                var neededFuel = distance * this.FuelConsumption;
                bool canContinue = this.FuelQuantity - neededFuel >= 0;

                if (canContinue)
                {
                    this.FuelQuantity -= neededFuel;
                }
                else
                {
                    throw new InvalidOperationException("Not enough fuel.");
                }
            }

        

        public string GetSpecifications()
            {

                var sb = new StringBuilder();
                sb.AppendLine($"Make: {this.Make}");
                sb.AppendLine($"Model: {this.Model}");
                sb.AppendLine($"Year: {this.Year}");
            sb.AppendLine($"Engine: {this.Engine}");
            sb.AppendLine($"Tyres: {this.Tyre}");
            sb.AppendLine($"Fuel: {this.FuelQuantity:f2}L");
                return sb.ToString();

            }
        }
    }

