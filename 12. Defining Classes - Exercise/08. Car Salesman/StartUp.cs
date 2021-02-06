﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Engine> engines = new List<Engine>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] engineArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                   .ToArray();

                Engine engine = null;

                string engineModel = engineArgs[0];
                int power = int.Parse(engineArgs[1]);

                //"{model} {power} {displacement} {efficiency}"
                if (engineArgs.Length == 2)
                {
                    engine = new Engine(engineModel, power);
                }
                else if (engineArgs.Length == 3)
                {
                    int displacement;

                    bool isDisplacement = int.TryParse(engineArgs[2],
                    out displacement);

                    if (isDisplacement)
                    {
                        engine = new Engine(engineModel, power, displacement);
                    }
                    else
                    {
                        string efficiency = engineArgs[2];
                        engine = new Engine(engineModel, power, efficiency);
                    }

                }
                else if (engineArgs.Length == 4)
                {
                    engineModel = engineArgs[0];
                    power = int.Parse(engineArgs[1]);
                    int displacement = int.Parse(engineArgs[2]);
                    string efficiency = engineArgs[3];

                    engine = new Engine(engineModel, power, displacement, efficiency);
                }
                if (engine != null)
                {
                    engines.Add(engine);
                }
            }

            int m = int.Parse(Console.ReadLine());


            for (int i = 0; i < m; i++)
            {
                string[] carArgs = Console.ReadLine()
                   .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                  .ToArray();

                Car car = null;

                string carModel = carArgs[0];

                // така си взимаме двигателя, който съответства на зададения инпут. В случая на двигателя
                //, който съвпада със зададената кола.
                Engine engine = engines.First(e => e.Model == carArgs[1]);


                if (carArgs.Length == 2)
                {
                    car = new Car(carModel, engine);
                }
                else if (carArgs.Length == 3)
                {

                    int weight;

                    bool isItWeight = int.TryParse(carArgs[2],
                        out weight);

                    if (isItWeight)
                    {
                        car = new Car(carModel, engine, weight);
                    }
                    else
                    {
                        string color = carArgs[2];
                        car = new Car(carModel, engine, color);
                    }

                }
                else if (carArgs.Length == 4)
                {


                    int weight = int.Parse(carArgs[2]);
                    string color = carArgs[3];

                    car = new Car(carModel, engine, weight, color);

                }

                if (car != null)
                {
                    cars.Add(car);
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

        }
    }
}
