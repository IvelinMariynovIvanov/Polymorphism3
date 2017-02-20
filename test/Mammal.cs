using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
   public abstract class Mammal:Animal
    {
        private string livingRegion;

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

        public Mammal(string animalName, string animalType, double animalWeight, string livingRegion)
            :base(animalName, animalType, animalWeight)
        {
            this.LivingRegion = livingRegion;
        }

        public override void MakeSound()
        {
            throw new NotImplementedException();
        }

        public override void Eat(Food food)
        {
            throw new NotImplementedException();
        }
    }
}
