using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1test
{
    class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumationPerKm, double tankCapacity) 
            : base(fuelQuantity, fuelConsumationPerKm, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
          if(distance <= this.FuelQuantity / FuelConsumationPerKm)
            {
                double counsumeLitterForGivvenDistance = distance * (FuelConsumationPerKm + 0.9);
                this.FuelQuantity -= counsumeLitterForGivvenDistance;
                Console.WriteLine($"Car travelled {distance} km");
            }
          else
                Console.WriteLine("Car needs refueling");
        }

        public override void Refuel(double litters)
        {
            if(litters > 0)
            {
                if (this.TankCapacity > this.FuelQuantity + litters)
                {
                    this.FuelQuantity += litters;
                }
            }
            else
                Console.WriteLine("Fuel must be a positive number");
        }
    }
}
