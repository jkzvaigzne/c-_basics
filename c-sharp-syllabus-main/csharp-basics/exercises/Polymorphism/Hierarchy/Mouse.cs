using System;

namespace Hierarchy
{
    public class Mouse : Mammal
    {
        public Mouse(string name, string type, double weight, string livingRegion)
            : base(name, type, weight, livingRegion) { }

        public override void MakeSound() => Console.WriteLine("Mouse make sounds...");

        public override void Eat(Food food)
        {
            if (food is Vegetable veg)
            {
                FoodEaten += veg.Quantity;
                Console.WriteLine("Mouse eats...");
            }
            else
            {
                Console.WriteLine($"{AnimalType} are not eating that type of food!");
            }
        }

        public override string ToString() => $"{base.ToString()}, {FoodEaten}]";
    }
}
