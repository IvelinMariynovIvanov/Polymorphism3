using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Wild_farm
{
   abstract public class Animal
    {
        private string animalName;
        private string animalType;
        private double animalWeight;
        private int foodEaten;

        public string AnimalName
        {
            get
            {
                return animalName;
            }

            set
            {
                animalName = value;
            }
        }

        public string AnimalType
        {
            get
            {
                return animalType;
            }

            set
            {
                animalType = value;
            }
        }

        public double AnimalWeight
        {
            get
            {
                return animalWeight;
            }

            set
            {
                animalWeight = value;
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

        public Animal( string animalType, string animalName, double animalWeight)
        {
            this.AnimalName = animalName;
            this.AnimalType = animalType;
            this.AnimalWeight = animalWeight;
            
        }

        public abstract void MakeSound();

        public abstract void Eat(Food food);
    }
}
