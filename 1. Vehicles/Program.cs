using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            string car = Console.ReadLine();
            string[] carInfo = car.Split(' ').ToArray();
            Car currentCar = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
            string truck = Console.ReadLine();
            string[] truckInfo = truck.Split(' ').ToArray();
            Truck currentTruck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));
            string bus = Console.ReadLine();
            string[] busInfo = bus.Split(' ').ToArray();
            Bus currentBus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));

            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                string command = Console.ReadLine();
                string[] commandInfo = command.Split(' ').ToArray();

                if (commandInfo[1] == "Car")
                {
                    if (commandInfo[0] == "Drive")
                    {
                        currentCar.Drive(double.Parse(commandInfo[2]));
                    }
                    else if(commandInfo[0] == "Refuel")
                    {
                        currentCar.Refuel(double.Parse(commandInfo[2]));
                    }
                }

                else if(commandInfo[1] == "Truck")
                {
                    if (commandInfo[0] == "Drive")
                    {
                        currentTruck.Drive(double.Parse(commandInfo[2]));
                    }
                    else if (commandInfo[0] == "Refuel")
                    {
                        currentTruck.Refuel(double.Parse(commandInfo[2]));
                    }
                }

                else if (commandInfo[1] == "Bus")
                {
                    if (commandInfo[0] == "Drive")
                    {
                        currentBus.Drive(double.Parse(commandInfo[2]));
                    }

                    else if (commandInfo[0] == "DriveEmpty")
                    {
                        currentBus.Drive(double.Parse(commandInfo[2]));
                    }

                    else if (commandInfo[0] == "Refuel")
                    {
                        currentBus.Refuel(double.Parse(commandInfo[2]));
                    }
                }

            }

            Console.WriteLine($"{currentCar.FuelQuantity:f2}");
            Console.WriteLine($"{currentTruck.FuelQuantity:f2}");
            Console.WriteLine($"{currentBus.FuelQuantity:f2}");
        }
    }
}
