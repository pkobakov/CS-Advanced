using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
   public  class Car
    {

        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Car(string manufac, string mod, int year)
        {
            Manufacturer = manufac;
            Model = mod;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Manufacturer} {Model} ({Year})";
        }
    }
}
