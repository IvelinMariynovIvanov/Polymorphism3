using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    public abstract class Mammal : Animal
    {
        private string livingRegion;


        public Mammal(string type, string name, double weight, string livingRegion) 
            : base(type, name, weight )
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion
        {
            get
            {
                return livingRegion;
            }

            set
            {
                livingRegion = value;
            }
        }
    }
}
