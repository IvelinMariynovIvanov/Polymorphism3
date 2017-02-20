using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = 1;
            List<Mammal> animals = new List<Mammal>();
            Dictionary<string, Food> foods = new Dictionary<string, Food>();

            while ( input != "End")
            {
                count++;
                if(count % 2 == 0)
                {
                    string[] animalInfo = input.Split(' ').ToArray();
                    if(animalInfo.Length == 4)
                    {
                        if (animalInfo[0] == "Mouse")
                        {
                            Mouse currentAnimal = new Mouse
                                (animalInfo[0], animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3]);
                            animals.Add(currentAnimal);
                        }
                        else if (animalInfo[0] == "Zebra")
                        {
                            Zebra currentAnimal = new Zebra
                                (animalInfo[0], animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3]);
                            animals.Add(currentAnimal);
                        }
                        else if(animalInfo[0] == "Tiger")
                        {
                            Tiger currentAnimal = new Tiger
                                (animalInfo[0], animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3]);
                            animals.Add(currentAnimal);
                        }
                    }
                    else
                    {
                        Cat currentAnimal = new Cat
                                (animalInfo[0], animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3],animalInfo[4]);
                        animals.Add(currentAnimal);
                    }
                }

                else
                {
                    string[] foodInfo = input.Split(' ').ToArray();
                    if(foodInfo[0] == "Meat")
                    {
                        Meat currentFood = new Meat(int.Parse(foodInfo[1]));
                        foods.Add(foodInfo[0],currentFood);
                    }
                    else if (foodInfo[0] == "Vegetable")
                    {
                        Vegetable currentFood = new Vegetable(int.Parse(foodInfo[1]));
                        foods.Add(foodInfo[0], currentFood);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                animal.MakeSound();
                Console.Write(animal.AnimalType + "[" + animal.AnimalName + "," + animal.AnimalWeight + "," 
                    + animal.LivingRegion + ",");
                Console.WriteLine();
                foreach (var food in foods)
                {
                    animal.Eat(food.Value);
                }
                Console.Write("]");
                Console.WriteLine();

            }

        }
    }
}
