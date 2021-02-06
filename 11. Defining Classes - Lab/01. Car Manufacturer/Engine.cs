using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Engine
    {

        public Engine(int horsePower, double cubicCapacity)
        {

            if (horsePower <= 0 || cubicCapacity <= 0)
            {
                throw new InvalidOperationException("Engine is not valid. Horse power and cubic capacity must be positive nubers.");
            }
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;

        }

        public int HorsePower { get; }
        public double CubicCapacity { get; }
    }
}
