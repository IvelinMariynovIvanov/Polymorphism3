using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExam10._07
{
   public static class Analyze
    {
        public static void GetHardwareComponents()
        {
            var result = ComponentFactory.Hardwares.Count();
            Console.WriteLine($"Hardware Components: {result}");
        }

        public static void GetSoftwareComponents()
        {
            int result = 0;
            foreach (var hardware in ComponentFactory.Hardwares)
            {
                result += hardware.Softwares.Count();
            }
            Console.WriteLine($"SoftwareComponents: {result}");
        }

        public static void TotalOperationalMemory()
        {
            int totalMemoryInUse = 0;
            int maxMemory = 0;

            foreach (var hardware in ComponentFactory.Hardwares)
            {
                maxMemory += hardware.MaxMemory;
                totalMemoryInUse += (hardware.MaxMemory - hardware.AvailableMemory);
            }

            Console.WriteLine($"TotalOperationalMemory: {totalMemoryInUse} / {maxMemory}");
        }

        public static void TotalCapacityTaken()
        {
            int totalcapacityTaken = 0;
            int maxCapacity = 0;

            foreach (var hardware in ComponentFactory.Hardwares)
            {
                maxCapacity += hardware.MaxCapacity;
                totalcapacityTaken += (hardware.MaxCapacity - hardware.AvailableCapacity);
            }
        }

        public static void PrintAnalyze()
        {
            Console.WriteLine("System Analysis");
            Analyze.GetHardwareComponents();
            Analyze.GetSoftwareComponents();
            Analyze.TotalOperationalMemory();
            Analyze.TotalCapacityTaken();
        }
    }
}
