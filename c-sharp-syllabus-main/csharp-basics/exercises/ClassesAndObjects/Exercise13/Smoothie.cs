using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise13
{
    public class Smoothie
    {
        private readonly Dictionary<string, decimal> ingredientPrices = new Dictionary<string, decimal>
        {
            { "Strawberries", 1.50m }, { "Banana", 0.50m }, { "Mango", 2.50m }, { "Blueberries", 1.00m }, { "Raspberries", 1.00m }, { "Apple", 1.75m }, { "Pineapple", 3.50m }
        };

        public string[] Ingredients { get; }
        private readonly decimal TaxRate = 1.5m;

        public Smoothie(string[] ingredients) => Ingredients = ingredients;

        public string GetName() =>
            string.Join(" ", Ingredients.Select(word => word.EndsWith("ies") ? word.Replace("ies", "y") : word).OrderBy(i => i))
            + (Ingredients.Length > 0 ? " Fusion" : " Smoothie");

        public string GetPrice() => $"£ {(CalculateCost() + CalculateCost() * TaxRate):F2} ";

        public string GetCost() => $"£ {CalculateCost():F2} ";

        private decimal CalculateCost() =>
            Ingredients.Sum(ingredient => ingredientPrices.ContainsKey(ingredient) ? ingredientPrices[ingredient] : 0m);
    }
}
