using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Vehicles
{
   public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumationInLittersPerKm;
        private double tankCapacity;

        public Vehicle(double fuelQuantity, double fuelConsumationInLittersPerKm, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumationInLittersPerKm = fuelConsumationInLittersPerKm;
            this.TankCapacity = tankCapacity;
        }

        public double FuelQuantity
        {
            get
            {
                return fuelQuantity;
            }

            set
            {
                if (value < 0)
                    throw new ArgumentException("Fuel must be a positive number");
                else
                fuelQuantity = value;
            }
        }

        public double FuelConsumationInLittersPerKm
        {
            get
            {
                return fuelConsumationInLittersPerKm;
            }

            set
            {
                fuelConsumationInLittersPerKm = value;
            }
        }

        public double TankCapacity
        {
            get
            {
                return tankCapacity;
            }

            set
            {
                tankCapacity = value;
            }
        }

        public abstract void Drive(double distance);

        public abstract void Refuel(double litters);

    }
}
