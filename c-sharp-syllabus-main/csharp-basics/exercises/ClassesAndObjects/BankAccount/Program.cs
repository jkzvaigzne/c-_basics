using System;

namespace BankAccount
{
    public class BankAccount
    {
        private string _name;
        private decimal _balance;

        public BankAccount(string name, decimal balance)
        {
            _name = name;
            _balance = balance;
        }

        public string ShowUserNameAndBalance()
        {
            if (_balance >= 0)
            {
                return $"{_name}, ${_balance:F2}";
            }
            else
            {
                return $"{_name}, -${Math.Abs(_balance):F2}";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount BankAccount = new BankAccount("John Doe", -99.99m);

            Console.WriteLine(BankAccount.ShowUserNameAndBalance());
            Console.Read();
        }
    }
}
