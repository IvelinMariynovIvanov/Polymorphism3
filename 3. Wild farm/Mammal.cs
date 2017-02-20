using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Wild_farm
{
    public abstract class Mammal:Animal
    {
        private string livingRegion;

        public Mammal(string animalName, string animalType, double animalWeight,  string livingRegion)
            :base(animalName, animalType, animalWeight)
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
