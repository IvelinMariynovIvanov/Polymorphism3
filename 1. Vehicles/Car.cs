using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumationInLittersPerKm, double tankCapacity) 
            : base(fuelQuantity, fuelConsumationInLittersPerKm, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            if(distance < this.FuelQuantity / (this.FuelConsumationInLittersPerKm + 0.9))
            {
                double result = distance * (this.FuelConsumationInLittersPerKm + 0.9);
                this.FuelQuantity -= result;
                Console.WriteLine($"Car travelled {distance} km ");
            }
            else
                Console.WriteLine("Car needs refueling");
          
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
