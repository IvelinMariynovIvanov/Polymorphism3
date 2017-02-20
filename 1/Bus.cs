using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity) 
            : base(fuelQuantity, fuelConsumptionPerKm, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            if (distance <= this.FuelQuantity / (this.FuelConsumptionPerKm + 1.4))
            {
                double result = distance * (this.FuelConsumptionPerKm + 1.4);
                this.FuelQuantity -= result;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Bus needs refuling");
            }
        }

        public void DriveEmpty(double distance)
        {
                if (distance <= this.FuelQuantity / (this.FuelConsumptionPerKm))
                {
                    double result = distance * (this.FuelConsumptionPerKm);
                    this.FuelQuantity -= result;
                    Console.WriteLine($"Bus travelled {distance} km");
                }
                else
                {
                    Console.WriteLine("Bus needs refuling");
                }
         }
        public override void Refuel(double litters)
        {
            if (litters > 0)  
            {
                if (TankCapacity >= this.FuelQuantity + litters)
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
