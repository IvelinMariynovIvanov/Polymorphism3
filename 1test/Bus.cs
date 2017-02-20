using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1test
{
    class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumationPerKm, double tankCapacity) 
            : base(fuelQuantity, fuelConsumationPerKm, tankCapacity)
        {
        }

        public void DriveEmpty(double distance)
        {
            if (distance <= this.FuelQuantity / FuelConsumationPerKm)
            {
                double counsumeLitterForGivvenDistance = distance * (FuelConsumationPerKm);
                this.FuelQuantity -= counsumeLitterForGivvenDistance;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
                Console.WriteLine("Bus needs refueling");
        }

        public override void Drive(double distance)
        {
            if (distance <= this.FuelQuantity / FuelConsumationPerKm)
            {
                double counsumeLitterForGivvenDistance = distance * (FuelConsumationPerKm + 1.4);
                this.FuelQuantity -= counsumeLitterForGivvenDistance;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
                Console.WriteLine("Bus needs refueling");
        }

        public override void Refuel(double litters)
        {
            if (litters > 0)
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
