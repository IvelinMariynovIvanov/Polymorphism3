using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumationInLittersPerKm, double tankCapacity) 
            : base(fuelQuantity, fuelConsumationInLittersPerKm, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            if (distance <= this.FuelQuantity / (this.FuelConsumationInLittersPerKm + 1.4))
            {
                double result = distance * (this.FuelConsumationInLittersPerKm + 1.4);
                this.FuelQuantity -= result;
                Console.WriteLine($"Bus travelled {distance} km ");
            }
            else
                Console.WriteLine("Bus needs refueling");
        }

        public void DriveEmpty(double distance)
        {
            if (distance <= this.FuelQuantity / (this.FuelConsumationInLittersPerKm))
            {
                double result = distance * (this.FuelConsumationInLittersPerKm);
                this.FuelQuantity -= result;
                Console.WriteLine($"Bus travelled {distance} km ");
            }
            else
                Console.WriteLine("Bus needs refueling");
        }

        public override void Refuel(double litters)
        {
            if (litters > 0)
            {
                if (TankCapacity > this.TankCapacity + litters)
                {
                    this.FuelQuantity += litters;
                }
                else
                    Console.WriteLine("Cannot fit fuel in tank");
            }
            else
                Console.WriteLine("Fuel must be a positive number");
        }
    }
}
