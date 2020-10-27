using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private List<Car> parking;

        public string Type { get; set; }
        public int Capacity { get; set; }

        public Parking(string type, int capacity)
        {
            parking = new List<Car>();
            Type = type;
            Capacity = capacity;
        }

        public int Count
        {
            get { return this.parking.Count; }
        }

        

        public void Add (Car car) 
        {
            if (Capacity>this.Count )
            {
                parking.Add(car);
            }
        
        }

        public bool Remove(string manufacturer, string model) 
        {
            foreach (var car in this.parking)
            {
                if (car.Manufacturer == manufacturer && car.Model == model)
                {
                    this.parking.Remove(car);

                    return true;
                }
            }

            return false;
        }

        public Car GetLatestCar() 
        {
            if (this.Count!=0)
            {
                Car latestCar = this.parking.OrderByDescending(x => x.Year).FirstOrDefault();
                return latestCar;
            }
            return null;
        
        }

        public Car GetCar(string manufacturer,  string model)
        {
            if (this.Count!=0)
            {
                foreach (var car in this.parking)
                {
                    if (car.Manufacturer==manufacturer&&car.Model==model)
                    {
                        return car;
                    }
                }

            }
            return null;
        }

        public string GetStatistics() 
        {
            StringBuilder print = new StringBuilder();

            print.AppendLine($"The cars are parked in {this.Type}:");
            foreach (var car in this.parking)
            {
                print.AppendLine(car.ToString());
            }
            return print.ToString().Trim();
        }







    }
}
