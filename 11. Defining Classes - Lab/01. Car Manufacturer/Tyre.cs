using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CarManufacturer
{
    public class Tyre
    {

        public int Year { get; }

        public double Pressure { get; set; }

        public Tyre(int year, double pressure)
        {
            // Можем да сложим валидация направо в пропъртито, когато пропъртитата на обекта са read only(само get-er). Ако има и
            // set-er трябва да създадем field и после да направим валидацията във set-ера.

            if (year < 2000 || pressure < 0)
            {
                throw new InvalidOperationException("Tyre is not valid. Year cannot be less than 2000 and pressure cannot be less than 0.");
            }

            this.Year = year;
            this.Pressure = pressure;
        }
    }
}
