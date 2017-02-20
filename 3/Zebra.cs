using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    public class Zebra : Mammal
    {
        public Zebra(string type, string name, double weight,  string livingRegion) 
            : base (type, name, weight, livingRegion)
        {
        }

        public override void Eat(Food food)
        {
            if (food is Vegetable)
            {
                this.FoodEaten += food.Quantity;
                Console.Write(FoodEaten);
            }
            else
                Console.WriteLine($"{this.Type} are not eating that type of food");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Zs");
        }
    }
}
