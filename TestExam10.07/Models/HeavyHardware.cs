using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestExam10._07
{
    public class HeavyHardware : Hardware
    {
        private const string heavyHardware = "HeavyHardware";

        public HeavyHardware(string name, int maxCapacity, int maxMemory) 
            : base(name, heavyHardware, maxCapacity, maxMemory)
        {

        }

        public override int MaxCapacity
        {
            get
            {
                return (int)(base.MaxCapacity * 2);
            }
        }

        public override int MaxMemory
        {
            get
            {
                return (int)(base.MaxMemory * 0.75);
            }
        }
    }
}