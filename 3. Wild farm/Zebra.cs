using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Wild_farm
{
    public class Zebra:Mammal
    {
        public Zebra( string animalType, string animalName,double animalWeight,  string livingRegion) 
            : base(animalName, animalType, animalWeight, livingRegion)
        {
        }

        public override void Eat(Food food)
        {
            if (food is Vegetable)
            {
                this.FoodEaten += food.Quantity;
                Console.WriteLine(FoodEaten);
            }
            else
                Console.WriteLine("Zebra are not eating that type of food!");

        }

        public override void MakeSound()
        {
            Console.WriteLine("Zs");
        }
    }
}
