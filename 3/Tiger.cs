using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    public class Tiger : Feline
    {
        public Tiger(string type, string name, double weight,  string livingRegion) 
            : base(name, type, weight, livingRegion)
        {
        }

        public override void Eat(Food food)
        {
           if(food is Meat)
            {
                this.FoodEaten += food.Quantity;
                Console.Write(FoodEaten);
            }
           else
                Console.WriteLine($"{this.Type} are not eating that type of food!");
        }

        public override void MakeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }
    }
}
