using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1test
{
    class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumationPerKm, double tankCapacity) 
            : base(fuelQuantity, fuelConsumationPerKm, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            if (distance <= this.FuelQuantity / FuelConsumationPerKm)
            {
                double counsumeLitterForGivvenDistance = distance * (FuelConsumationPerKm + 1.6);
                this.FuelQuantity -= counsumeLitterForGivvenDistance;
                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
                Console.WriteLine("Truck needs refueling");
        }

        public override void Refuel(double litters)
        {
           if(litters > 0)
            {
                this.FuelQuantity += litters * 0.95;
            }
           else
                Console.WriteLine("Fuel must be a positive number");
        }
    }
}
