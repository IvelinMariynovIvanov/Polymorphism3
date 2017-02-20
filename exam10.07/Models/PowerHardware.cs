using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exam10._07
{
    public class PowerHardware : Hardware
    {
        private const string powerType = "Power";


        public PowerHardware(string name, int maximumCapacity, int maximumMemory) 
            : base(name, powerType, maximumCapacity, maximumMemory)
        {

        }

        public override int MaximumCapacity
        {
            get
            {
                return (int)(base.MaximumCapacity * 0.25);
            }

           
        }

        public override int MaximumMemory
        {
            get
            {
                return (int)(base.MaximumMemory*1.75);
            }

            
        }
    }
}