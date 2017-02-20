using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public abstract class Feline : Mammal
    {
        public Feline(string animalName, string animalType, double animalWeight, string livingRegion) 
            : base(animalName, animalType, animalWeight,livingRegion)
        {
        }

        public override void MakeSound()
        {
            base.MakeSound();
        }

        public override void Eat(Food food)
        {
            base.Eat(food);
        }

    }
}
