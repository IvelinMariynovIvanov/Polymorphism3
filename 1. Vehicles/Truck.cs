using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumationInLittersPerKm, double tankCapacity) 
            : base(fuelQuantity, fuelConsumationInLittersPerKm, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            if (distance <= this.FuelQuantity / (this.FuelConsumationInLittersPerKm + 1.6))
            {
                double result = distance * (this.FuelConsumationInLittersPerKm + 1.6);
                this.FuelQuantity -= result;
                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
                Console.WriteLine("Truck needs refueling");
        }

        public override void Refuel(double litters)
        {
            if (litters > 0)
            {
                this.FuelQuantity += litters * 0.95;
            }

            else
                Console.WriteLine("Fuel must be a positive number");
        }

         
    }
}
