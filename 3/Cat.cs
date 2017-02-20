using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    public class Cat : Feline
    {
        public string breed;

        public Cat(string type, string name, double weight,string livingRegion, string breed) 
            : base( name, type, weight, livingRegion)
        {
        }

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

        public override void Eat(Food food)
        {
            this.FoodEaten += food.Quantity;
            Console.Write(FoodEaten);
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }
    }
}
