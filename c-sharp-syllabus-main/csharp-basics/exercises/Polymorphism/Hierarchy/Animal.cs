using System;

namespace Hierarchy
{
    public abstract class Animal
    {
        public string AnimalName { get; set; }
        public string AnimalType { get; set; }
        public double AnimalWieght { get; set; }
        public int FoodEaten { get; set; }

        public abstract void MakeSound();
        public abstract void Eat(Food food);

        public Animal(string name, string type, double weight) 
            => (AnimalName, AnimalType, AnimalWieght, FoodEaten) = (name, type, weight, 0);

        public override string ToString() => $"{AnimalType}[{AnimalName}, {AnimalWieght:#} kg]";
    }
}
