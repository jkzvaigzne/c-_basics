using System;

namespace Hierarchy
{
    public class Tiger : Felime
    {
        public Tiger(string name, string type, double weight, string livingRegion)
            : base(name, type, weight, livingRegion) { }

        public override void Eat(Food food)
        {
            if (food is Meat meat)
            {
                Console.WriteLine("Tiger eats...");
                FoodEaten += meat.Quantity;
            }
            else
            {
                Console.WriteLine($"{AnimalType} are not eating that type of food!");
            }
        }

        public override void MakeSound() => Console.WriteLine("Tiger make sounds...");

        public override string ToString() => $"{base.ToString()}, {FoodEaten}]";
    }
}
