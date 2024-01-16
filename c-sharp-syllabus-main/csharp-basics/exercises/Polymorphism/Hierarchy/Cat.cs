using System;

namespace Hierarchy
{
    public class Cat : Felime
    {
        public string Breed { get; set; }

        public Cat(string name, string type, double weight, string livingRegion, string breed)
            : base(name, type, weight, livingRegion) => Breed = breed;

        public override void MakeSound() => Console.WriteLine("Cat make sounds...");

        public override void Eat(Food food)
        {
            Console.WriteLine("Cat eats...");
            FoodEaten += food.Quantity;
        }

        public override string ToString() => $"{base.ToString()}, {Breed}, {FoodEaten}]";
    }
}
