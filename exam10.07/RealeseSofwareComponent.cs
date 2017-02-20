using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam10._07
{
   public static class RealeseSofwareComponent
    {
        public static void Realese(string input)
        {
            string[] info = input.Split(new char[] { ' ', '(', ')', ',' }, 
                StringSplitOptions.RemoveEmptyEntries).ToArray();
            string hardwareComponentName = info[1];
            string softwareComponentName = info[2];

            Hardware curentHardware = ComponentFactory.
                Hardwares.FirstOrDefault(hd => hd.Name == hardwareComponentName);
            Software curentSoftware = curentHardware.softwares.
                FirstOrDefault(sf => sf.Name == softwareComponentName);

            curentHardware.AvailableCapacity += curentSoftware.CapacityConsumtion;
            curentHardware.AvailableMemory += curentSoftware.MemoryConsumtion;

            curentHardware.softwares.Remove(curentSoftware);
        }
    }
}
