using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestExam10._07
{
    public class ExpressSoftware : Software
    {
        private const string expressSoftware = "ExpressSoftware";

        public ExpressSoftware(string name, int capacityConsumption, int memoryConsumption) 
            : base(name, expressSoftware, capacityConsumption, memoryConsumption)
        {

        }

        public override int MemoryConsumption
        {
            get
            {
                return (int)(base.MemoryConsumption*2);
            }

        }
    }
}