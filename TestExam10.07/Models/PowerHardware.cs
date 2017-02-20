using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestExam10._07
{
    public class PowerHardware : Hardware
    {
        private const string powerHardware = "PowerHardware";

        public PowerHardware(string name, int maxCapacity, int maxMemory) 
            : base(name, powerHardware, maxCapacity, maxMemory)
        {

        }

        public override int MaxCapacity
        {
            get
            {
                return (int)(base.MaxCapacity*0.25);
            }
        }

        public override int MaxMemory
        {
            get
            {
                return (int)(base.MaxMemory*1.75);
            }
        }
    }
}