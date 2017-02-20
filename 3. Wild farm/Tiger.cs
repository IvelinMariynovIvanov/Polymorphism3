using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Wild_farm
{
    public class Tiger : Feline
    {
        

        public Tiger( string animalType, string animalName, double animalWeight,  string livingRegion) 
            : base(animalName, animalType, animalWeight,  livingRegion)
        {
            
        }

      

        public override void MakeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }

        public override void Eat(Food food)
        {
            if (food is Meat)
            {
                this.FoodEaten += food.Quantity;
                Console.WriteLine(FoodEaten);
            }
            else
                Console.WriteLine("Tiger are not eating that type of food!");

        }
    }
}
