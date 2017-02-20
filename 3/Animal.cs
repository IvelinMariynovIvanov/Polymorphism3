using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    public abstract class Animal
    {
        private string name;
        private string type;
        private double weight;
        private int foodEaten;

        public Animal(string type, string name, double weight)
        {
            
            Type = type;
            Name = name;
            Weight = weight;
            FoodEaten = foodEaten = 0;
        }

        public abstract void MakeSound();

        public abstract void Eat(Food food);

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }

        public int FoodEaten
        {
            get
            {
                return foodEaten;
            }

            set
            {
                foodEaten = value;
            }
        }
    }
}
