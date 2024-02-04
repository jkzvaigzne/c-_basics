using System;
using System.Linq;
using System.Collections.Generic;

namespace VendingMachine
{
    internal class Program
    {
        private static IVendingMachine _myVendingMachine;
        private const string _name = "VENGMGURU";
        private const int _capacity = 20;

        static void Main(string[] args)
        {
            _myVendingMachine = new VendingMachine(_name, _capacity);

            UpdateInventory();
            _myVendingMachine.DisplayProducts();

            char userInput;

            var userActions = new Dictionary<char, Action>
            {
                ['1'] = InsertCoin,
                ['2'] = BuyProduct,
                ['3'] = AddProduct,
                ['4'] = GetBackMoney,
                ['5'] = () => { Console.Clear(); _myVendingMachine.DisplayProducts(); }
            };

            do
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Menu:\n1 - Insert Coin\n2 - Buy Product\n3 - Add Product\n4 - Get back money\n5 - List Products\n6 - Exit");
                userInput = Console.ReadKey().KeyChar;

                if (userActions.TryGetValue(userInput, out var action))
                {
                    action.Invoke();
                }
            } while (userInput != '6');

            Console.Read();
        }

        private static void UpdateInventory()
        {
            List<Product> products = new List<Product>
            {
                new Product("Expreso Coffee (S)", new Money(1, 50), 15),
                new Product("White Coffee (S)", new Money(1,20), 15),
                new Product("Driking Water (500ml)", new Money(1, 10), 15),
                new Product("Doritos Chips (85g)", new Money(1, 50), 15),
                new Product("M&M (90g)", new Money(1, 50), 15),
                new Product("Coca-Cola (500ml)", new Money(1, 50), 15),
                new Product("Fanta (500ml)", new Money(1, 50), 15),
                new Product("Sprite (500ml)", new Money(1, 50), 15),
                new Product("Fresh Apple (2 pieces)", new Money(2, 50), 15),
                new Product("Fresh Orange (2 pieces)", new Money(2, 50), 15),
            };

            foreach (var product in products.Take(_capacity))
            {
                if (!_myVendingMachine.AddProduct(product.Name, product.Price, product.Available))
                    break;
            }
        }

        private static void AddProduct()
        {
            while (true)
            {
                Console.WriteLine("Enter product details (Name, Price, Quantity):");
                string[] input = Console.ReadLine()?.Split(',').Select(s => s.Trim()).ToArray();

                if (input?.Length == 3 && decimal.TryParse(input[1], out decimal price) && int.TryParse(input[2], out int quantity))
                {
                    _myVendingMachine.AddProduct(input[0], GetMoneyFromDecimal(price), quantity);
                    Console.WriteLine("Product added successfully!");
                    break;
                }
            }
        }

        private static void BuyProduct()
        {
            int userChoice = GetValidProductChoice("Enter number of product, you want to buy!");
            Product selectedProduct = _myVendingMachine.Products[userChoice];

            if (selectedProduct.Available > 0)
            {
                decimal price = GetDecimalFromMoney(selectedProduct.Price);
                decimal insertedMoney = GetDecimalFromMoney(_myVendingMachine.Amount);

                while (price > insertedMoney)
                {
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("You don't have enough money!");
                    return;
                }

                _myVendingMachine.UpdateProduct(userChoice, selectedProduct.Name, selectedProduct.Price, selectedProduct.Available - 1);
                _myVendingMachine.SetAmount(GetMoneyFromDecimal(insertedMoney - price));

                Console.WriteLine("----------------------------------");
                Console.WriteLine($"You bought {selectedProduct.Name}");
                Console.WriteLine($"Money: {_myVendingMachine.Amount}");
            }
            else
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Out of stock!");
            }
        }

        private static int GetValidProductChoice(string message)
        {
            int userChoice;

            while (true)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine(message);

                if (int.TryParse(Console.ReadLine(), out userChoice) && userChoice >= 0 && userChoice < _capacity &&
                    _myVendingMachine.Products[userChoice].Name != null)
                {
                    return userChoice;
                }
                else
                {
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("Invalid input!");
                }
            }
        }

        private static void GetBackMoney()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Take your change: {_myVendingMachine.Amount.ToString()}");
        }

        private static decimal GetDecimalFromMoney(Money money) => money.Euros + money.Cents / 100.0m;

        private static Money GetMoneyFromDecimal(decimal money)
        {
            int totalCents = (int)(money * 100);
            int euros = totalCents / 100;
            int cents = totalCents % 100;

            return new Money(euros, cents);
        }

        private static void InsertCoin()
        {
            Console.WriteLine("Insert coin (0.10, 0.20, 0.50, 1.00, 2.00):");
            if (Enum.TryParse(Console.ReadLine(), out CoinType coinType))
                _myVendingMachine.InsertCoin(GetCoinType(coinType));
        }

        private enum CoinType
        {
            OneEuro,
            TwoEuro,
            FiftyCents,
            TwentyCents,
            TenCents
        }

        private static Money GetCoinType(CoinType coinType)
        {
            return coinType switch
            {
                CoinType.OneEuro => new Money(1, 0),
                CoinType.TwoEuro => new Money(2, 0),
                CoinType.FiftyCents => new Money(0, 50),
                CoinType.TwentyCents => new Money(0, 20),
                CoinType.TenCents => new Money(0, 10),
                _ => new Money(),
            };
        }
    }
}
