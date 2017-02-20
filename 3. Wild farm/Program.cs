using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Wild_farm
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            Mammal animal = null;
            Food food = null;

            string input = Console.ReadLine();
            while(input != "End")
            {
                if(count %2 == 1)
                {
                    string[] animalInfo = input.Split(' ').ToArray();
                    if (animalInfo.Length == 4)
                    {
                        if (animalInfo[0] == "Tiger")
                        {
                            animal = new Tiger(animalInfo[0], animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3]);

                        }

                        if (animalInfo[0] == "Mouse")
                        {
                            animal = new Mouse(animalInfo[0], animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3]);

                        }
                        if (animalInfo[0] == "Zebra")
                        {
                            animal = new Zebra(animalInfo[0], animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3]);

                        }
                    }

                    else
                    {
                        animal = new Cat(animalInfo[0], animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3], animalInfo[4]);
                    }
                }
                else
                {
                    string[] foods = input.Split(' ').ToArray();
                    

                    if (foods[0] == "Meat")
                    {
                        food = new Meat(int.Parse(foods[1]));
                    }
                    else
                    {
                        food = new Vegetable(int.Parse(foods[1]));
                    }


                    Console.WriteLine();
                    animal.MakeSound();
                    Console.Write(animal.AnimalType + "[" + animal.AnimalName + "," + animal.AnimalWeight + ","
                        + animal.LivingRegion + ",");
                    animal.Eat(food);
                    Console.Write("]");
                    Console.WriteLine();
                }

                count++;

                input = Console.ReadLine();
            }

        }
    }
}
