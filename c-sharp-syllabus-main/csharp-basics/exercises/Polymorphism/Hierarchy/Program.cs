using System;
using System.Collections.Generic;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animaLi = new List<Animal>();

            while (true)
            {
                Console.WriteLine($"Enter animal details and use space to separated.");
                Console.WriteLine("Animal Name, Animal Type, Animal Weight, Animal Region");
                string userChoiceInput = Console.ReadLine().ToLower();
                if (userChoiceInput.ToLower() == "end") break;

                string[] animalInformation = userChoiceInput.Split(" ");
                Animal nAnimal = GetAnimal(animalInformation);

                nAnimal.MakeSound();

                Console.WriteLine("What do you want to feed? How much (Vegetable / Meat)");
                Console.WriteLine("Please enter (type-quantity)");

                string[] foodCounter = Console.ReadLine().Split(" ");
                Food food = GetFood(foodCounter);

                nAnimal.Eat(food);

                Console.WriteLine(nAnimal);
                animaLi.Add(nAnimal);
            }

            foreach (Animal animal in animaLi)
            {
                Console.WriteLine(animal);
            }

            Console.Read();
        }

        static Food GetFood(string[] foodCounter)
        {
            string food = foodCounter[0].Trim().ToLower();
            int count = int.Parse(foodCounter[1].Trim());

            return food.ToLower() == "meat" ? new Meat(count) : new Vegetable(count);
        }

        static Animal GetAnimal(string[] animalInfo)
        {
            string name = animalInfo[0].Trim().ToLower();
            string type = animalInfo[1].Trim().ToLower();
            double weight = double.Parse(animalInfo[2].Trim());
            string livingRegion = animalInfo[3].Trim().ToLower();

            return type switch
            {
                "mouse" => new Mouse(name, type, weight, livingRegion),
                "tiger" => new Tiger(name, type, weight, livingRegion),
                "zebra" => new Zebra(name, type, weight, livingRegion),
                "cat" => new Cat(name, type, weight, livingRegion, animalInfo[4].Trim().ToLower()),
                _ => throw new InvalidOperationException("Not valid!")
            };
        }
    }
}
