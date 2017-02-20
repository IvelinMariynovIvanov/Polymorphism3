using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Wild_farm
{
    public abstract class Feline : Mammal
    {
        

        public Feline( string animalType, string animalName, double animalWeight,  string livingRegion) 
            : base(animalName, animalType, animalWeight, livingRegion)
        {
            
        }

        public override void MakeSound()
        {
            throw new NotImplementedException();
        }

        public override void  Eat(Food food)
        {
            throw new NotImplementedException();
        }
    }
}
