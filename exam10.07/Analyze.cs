using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam10._07
{
   public class Analyze
    {
        public static void GetNumberOfHardwareComponents()
        {
            var result = ComponentFactory.Hardwares.Count;
            Console.WriteLine($"Hardware Components: {result}");
        }

        public static void GetNumberOfSoftwareComponents()
        {
            int result = 0;
            foreach (var hardware in ComponentFactory.Hardwares)
            {
                result += hardware.softwares.Count;
            }
            Console.WriteLine($"Software Components: {result}");
        }

        public static void GetTotalOperationalMemoryInUSe()
        {
            int memoryInUse = 0;
            int maxMemory = 0;

            foreach (var hardware in ComponentFactory.Hardwares)
            {
                memoryInUse += (hardware.MaximumMemory - hardware.AvailableMemory);
                maxMemory += hardware.MaximumMemory;
            }
           
            Console.WriteLine($"TotalOperationalMemory: {memoryInUse} / {maxMemory}");
        }

        public static void GetTotalCapacityTaken()
        {
            int capacitytaken = 0;
            int maxCapacity = 0;
            foreach (var hardware in ComponentFactory.Hardwares)
            {
                capacitytaken += (hardware.MaximumCapacity - hardware.AvailableCapacity);
                maxCapacity += hardware.MaximumCapacity;
            }

            Console.WriteLine($"TotalCapacityTaken: {capacitytaken} / {maxCapacity}");
        }

        public static void PrintAnalyze()
        {
            Console.WriteLine("System Analysis");
            Analyze.GetNumberOfHardwareComponents();
            Analyze.GetNumberOfSoftwareComponents();
            Analyze.GetTotalOperationalMemoryInUSe();
            Analyze.GetTotalCapacityTaken();
        }

    }
}
