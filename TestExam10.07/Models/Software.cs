using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestExam10._07
{
    public abstract class Software : Component
    {
        private int capacityConsumption;
        private int memoryConsumption;

        public Software(string name, string type, int capacityConsumption, int memoryConsumption) 
            : base(name, type)
        {
            this.CapacityConsumption = capacityConsumption;
            this.MemoryConsumption = memoryConsumption;
        }

        public virtual int CapacityConsumption
        {
            get
            {
                return capacityConsumption;
            }

          protected  set
            {
                capacityConsumption = value;
            }
        }

        public virtual int MemoryConsumption
        {
            get
            {
                return memoryConsumption;
            }

         protected   set
            {
                memoryConsumption = value;
            }
        }
    }
}