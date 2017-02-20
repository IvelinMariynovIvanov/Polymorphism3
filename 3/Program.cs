using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int numberOfInputLines = 1;
            Mammal animall = null;
            Food foodd = null;
            List<Animal> animals = new List<Animal>();

            while (input != "End")
            {
                numberOfInputLines++;
                if (numberOfInputLines % 2 == 0)
                {
                    string[] animal = input.Split().ToArray();
                    string animalType = animal[0];
                    if (animal.Length == 4)
                    {
                        if (animalType == "Tiger")
                        {
                            animall = new Tiger(animalType, animal[1], double.Parse(animal[2]),
                                (animal[3]));
                            animals.Add(animall);
                        }
                        else if (animalType == "Zebra")
                        {
                            animall = new Zebra(animalType, animal[1], double.Parse(animal[2]),
                                (animal[3]));
                            animals.Add(animall);
                        }
                        else if (animalType == "Mouse")
                        {
                            animall = new Mouse(animalType, animal[1], double.Parse(animal[2]),
                                (animal[3]));
                            animals.Add(animall);
                        }
                    }
                    else
                    {
                        animall = new Cat(animalType, animal[1], double.Parse(animal[2]),
                                (animal[3]), animal[4]);
                        animals.Add(animall);
                    }
                }
                else
                {
                    string[] food = input.Split().ToArray();
                    string foodType = food[0];
                    if (foodType == "Meat")
                    {
                        foodd = new Meat(int.Parse(food[1]));
                    }
                    else
                    {
                        foodd = new Vegetable(int.Parse(food[1]));
                    }
                }
                
                Console.WriteLine();
                if (animall.Type != "Cat")
                {
                    Console.Write(animall.Type + "[" + animall.Name + "," + animall.Weight + ","
                       + animall.LivingRegion + ",");
                }
  
                animall.Eat(foodd);
                Console.WriteLine("]");
                Console.WriteLine();
                input = Console.ReadLine();

            }

           
           
            }
           
        }
    }

