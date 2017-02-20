using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExam10._07
{
  public static  class ReleaseSoftwareComponent
    {
        public static void Release(string input)
        {
            string[] info = input.Split(new char[] { ' ', '(', ')', ',' },
                StringSplitOptions.RemoveEmptyEntries).ToArray();
            string hardwareName = info[1];
            string softwareName = info[2];

            Hardware hd = ComponentFactory.Hardwares.
                FirstOrDefault(hardware=>hardware.Name == hardwareName);
            Software sf = hd.Softwares.
                FirstOrDefault(software => software.Name == softwareName);

            hd.AvailableCapacity += sf.CapacityConsumption;
            hd.AvailableMemory += sf.MemoryConsumption;

            hd.Softwares.Remove(sf);
        }
    }
}
