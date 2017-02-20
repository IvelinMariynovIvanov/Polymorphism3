using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Cat : Feline
    {
        private string breed;

        public string Breed
        {
            get
            {
                return breed;
            }

            set
            {
                breed = value;
            }
        }

        public Cat(string animalName, string animalType, double animalWeight, string livingRegion, string breed)
           : base(animalName, animalType, animalWeight, livingRegion)
        {
            this.Breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }

        public override void Eat(Food food)
        {
            this.FoodEaten += food.Quantity;
            Console.WriteLine(FoodEaten);
        }
    }
}
