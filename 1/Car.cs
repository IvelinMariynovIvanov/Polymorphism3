using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity) 
            : base(fuelQuantity, fuelConsumptionPerKm,  tankCapacity)
        {
        }

        public  double FuelConsumptionPerKm
        {
            get
            {
                return base.FuelConsumptionPerKm;
            }

            set
            {
                base.FuelConsumptionPerKm = value;
            }
        }

        public override void Drive(double distance)
        {
            if (distance <= (this.FuelQuantity / this.FuelConsumptionPerKm))
            {
                double result = distance* (this.FuelConsumptionPerKm + 0.9);
                this.FuelQuantity -= (int)result;
                Console.WriteLine($"Car travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Car needs refueling");
            }
        }

        public override void Refuel(double litters)
        {
            if(litters > 0)
            {
                if (this.TankCapacity >= this.FuelQuantity + litters)
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
