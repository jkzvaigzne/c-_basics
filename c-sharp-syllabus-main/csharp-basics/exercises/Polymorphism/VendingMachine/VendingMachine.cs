using System;
using System.Linq;

namespace VendingMachine
{
    public class VendingMachine : IVendingMachine
    {
        public string Manufacturer { get; }

        public bool HasProducts => Products != null;

        public Money Amount { get; set; }

        public Product[] Products { get; set; }

        public VendingMachine(string manufacturer, int capacity)
        {
            Manufacturer = manufacturer;
            Products = new Product[capacity];
        }

        public Money InsertCoin(Money amount)
        {
            if (amount.Euros == 1 || amount.Euros == 2)
            {
                Amount = new Money(Amount.Euros + amount.Euros, Amount.Cents);

                return new Money(0, 00);
            }
            else if (amount.Cents == 10 || amount.Cents == 20 || amount.Cents == 50)
            {
                int totalCents = Amount.Cents + amount.Cents;

                if (totalCents >= 100)
                {
                    Amount = new Money(Amount.Euros + 1, Amount.Cents - Amount.Cents + (totalCents - 100));
                }
                else
                {
                    Amount = new Money(Amount.Euros, totalCents);
                }

                return new Money(0, 00);
            }

            return amount;
        }

        public Money ReturnMoney()
        {
            return Amount;
        }

        public void SetAmount(Money amount)
        {
            this.Amount = amount;
        }

        public bool AddProduct(string name, Money price, int count)
        {
            Product product = new Product(name, price, count);

            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].Name == null)
                {
                    Products[i] = product;

                    return true;
                }
            }

            return false;
        }

        public bool UpdateProduct(int productNumber, string name, Money? price, int amount)
        {
            if (productNumber >= 0 && productNumber <= Products.Length)
            {
                Products[productNumber].Name = name;

                if (price != null)
                {
                    Products[productNumber].Price = price.Value;
                }

                Products[productNumber].Available = amount;

                return true;
            }

            return false;
        }

        public void DisplayProducts()
        {
            Console.WriteLine($"Manufactured by {Manufacturer}");

            foreach (Product product in Products.Where(p => p.Name != null))
            {
                Console.WriteLine($"{Array.IndexOf(Products, product)} - {product.ToString()}");
            }
        }
    }
}