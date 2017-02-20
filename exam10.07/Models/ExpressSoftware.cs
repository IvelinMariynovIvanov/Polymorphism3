using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exam10._07
{
    public class ExpressSoftware : Software
    {
        private const string expressType = "Express";
        

        public ExpressSoftware(string name, int capacityConsumtion, int memoryConsumtion) 
            : base(name, expressType, capacityConsumtion, memoryConsumtion)
        {

        }

        public override int MemoryConsumtion
        {
            get
            {
                return base.MemoryConsumtion*2;
            }

           
        }
    }
}