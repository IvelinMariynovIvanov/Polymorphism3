using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exam10._07
{
    public abstract class Software : Component
    {
        private int capacityConsumtion;
        private int memoryConsumtion;
        

        public Software(string name, string type, int capacityConsumtion, int memoryConsumtion) 
            : base(name, type)
        {
            this.CapacityConsumtion = capacityConsumtion;
            this.MemoryConsumtion = memoryConsumtion;
        }

        public virtual int CapacityConsumtion
        {
            get
            {
                return capacityConsumtion;
            }

          protected  set
            {
                capacityConsumtion = value;
            }
        }

        public virtual int MemoryConsumtion
        {
            get
            {
                return memoryConsumtion;
            }

          protected  set
            {
                memoryConsumtion = value;
            }
        }

       
    }
}