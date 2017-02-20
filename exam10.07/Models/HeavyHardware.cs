using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exam10._07
{
    public class HeavyHardware : Hardware
    {
        private const string heavyType = "Heavy";


        public HeavyHardware(string name, int maximumCapacity, int maximumMemory) 
            : base(name, heavyType, maximumCapacity, maximumMemory)
        {

        }

        public override int MaximumCapacity
        {
            get
            {
                return (int)(base.MaximumCapacity * 2);
            }


        }

        public override int MaximumMemory
        {
            get
            {
                return (int)(base.MaximumMemory * 0.75);
            }


        }
    }
}