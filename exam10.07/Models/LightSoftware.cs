using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exam10._07
{
    public class LightSoftware : Software
    {
        private const string lightType = "Light";


        public LightSoftware(string name, int capacityConsumtion, int memoryConsumtion) 
            : base(name, lightType, capacityConsumtion, memoryConsumtion)
        {

        }

        public override int MemoryConsumtion
        {
            get
            {
                return base.MemoryConsumtion /2;
            }
        }

        public override int CapacityConsumtion
        {
            get
            {
                return (int)(base.CapacityConsumtion *1.5);
            }

        }
    }
}