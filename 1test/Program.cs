using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carr = Console.ReadLine().Split();
            Car car = new Car(double.Parse(carr[1]), double.Parse(carr[2]), double.Parse(carr[3]));

            string[] truckk = Console.ReadLine().Split().ToArray();
            Truck truck = new Truck(double.Parse(truckk[1]), double.Parse(truckk[2]), double.Parse(truckk[3]));

            string[] buss = Console.ReadLine().Split().ToArray();
            Bus bus = new Bus(double.Parse(buss[1]), double.Parse(buss[2]), double.Parse(buss[3]));

            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string command = input[0];
                string vehicle = input[1];
                if(vehicle == "Car")
                {
                    if (command == "Drive")
                    {
                        car.Drive(double.Parse(input[2]));
                    }
                    else
                    car.Refuel(double.Parse(input[2])); 
                }
                else if(vehicle == "Truck")
                {
                    if (command == "Drive")
                    {
                        truck.Drive(double.Parse(input[2]));
                    }
                    else
                        truck.Refuel(double.Parse(input[2]));
                }
                else if(vehicle == "Bus")
                {
                    if(command == "Drive")
                    {
                        bus.Drive(double.Parse(input[2]));
                    }
                    else if(command == "DriveEmpty")
                    {
                        bus.DriveEmpty(double.Parse(input[2]));
                    }
                    else if(command == "Refuel")
                    {
                        bus.Refuel(double.Parse(input[2]));
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }
    }
}
