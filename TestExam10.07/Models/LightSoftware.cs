using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestExam10._07
{
    public class LightSoftware : Software
    {
        private const string lightSoftware = "LightSoftware";

        public LightSoftware(string name, int capacityConsumption, int memoryConsumption) 
            : base(name, lightSoftware, capacityConsumption, memoryConsumption)
        {

        }

        public override int CapacityConsumption
        {
            get
            {
                return (int)(base.CapacityConsumption * 1.5);
            }
        }

        public override int MemoryConsumption
        {
            get
            {
                return (int)(base.MemoryConsumption * 0.5);
            }
        }
    }
}