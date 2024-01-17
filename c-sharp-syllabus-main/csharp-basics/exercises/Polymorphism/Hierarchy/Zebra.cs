using System;

namespace Hierarchy
{
    public class Zebra : Mammal
    {
        public Zebra(string name, string type, double weight, string livingRegion)
            : base(name, type, weight, livingRegion) { }

        public override void MakeSound() => Console.WriteLine("Zebra make sounds...");

        public override void Eat(Food food)
        {
            if (food is Vegetable veg)
            {
                FoodEaten += veg.Quantity;
                Console.WriteLine("Zebra eats...");
            }
            else
            {
                Console.WriteLine($"{AnimalType} are not eating that type of food!");
            }
        }

        public override string ToString() => $"{base.ToString()}, {FoodEaten}]";
    }
}
