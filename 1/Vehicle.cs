using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
   public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumptionPerKm;
        private double tankCapacity;

        public Vehicle(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumptionPerKm = fuelConsumptionPerKm;
            TankCapacity = tankCapacity;
        }

        public  double FuelQuantity
        {
            get
            {
                return fuelQuantity;
            }

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Fuel must be a positive number");
                }
                fuelQuantity = value;
            }
        }

        public  double FuelConsumptionPerKm
        {
            get
            {
                return fuelConsumptionPerKm;
            }

            set
            {
                fuelConsumptionPerKm = value;
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
