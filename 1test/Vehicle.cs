﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1test
{
 public abstract   class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumationPerKm;
        private double tankCapacity;

        public Vehicle(double fuelQuantity, double fuelConsumationPerKm, double tankCapacity)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumationPerKm = fuelConsumationPerKm;
            TankCapacity = tankCapacity;
        }

        public abstract void Drive(double distance);

        public abstract void Refuel(double litters);

        public double FuelQuantity
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

        public double FuelConsumationPerKm
        {
            get
            {
                return fuelConsumationPerKm;
            }

            set
            {
                fuelConsumationPerKm = value;
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
    }
}
