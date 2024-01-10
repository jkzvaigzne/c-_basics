using System;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            FirstAccount();
            Console.WriteLine();
            Console.ReadKey();

            MoneyTransfer();
            Console.WriteLine();
            Console.ReadKey();

            Account a = new Account("A", 100.0m, 1);
            Account b = new Account("B", 0.0m, 2);
            Account c = new Account("C", 0.0m, 3);

            Console.WriteLine($"{a.AccountName()} - {a.AccountBalance()}");
            Console.WriteLine($"{b.AccountName()} - {b.AccountBalance()}");
            Console.WriteLine($"{c.AccountName()} - {c.AccountBalance()}");

            Account.Bank.Transfer(a, b, 50.0m);
            Account.Bank.Transfer(b, c, 25.0m);

            Console.WriteLine($"{a.AccountName()} - {a.AccountBalance()}");
            Console.WriteLine($"{b.AccountName()} - {b.AccountBalance()}");
            Console.WriteLine($"{c.AccountName()} - {c.AccountBalance()}");

            Console.ReadKey();
        }

        static void FirstAccount()
        {
            Account bartosAccount = new Account("Barto's account", 100.00m, 1);
            Account bartosSwissAccount = new Account("Barto's account in Switzerland", 1000000.00m, 2);

            Console.WriteLine("Initial state");
            Console.WriteLine($"{bartosAccount.AccountName()} - {bartosAccount.AccountBalance()}");
            Console.WriteLine($"{bartosSwissAccount.AccountName()} - {bartosSwissAccount.AccountBalance()}");

            bartosAccount.AccountWithdrawal(20);
            Console.WriteLine($"Barto's account balance is now: {bartosAccount.AccountBalance()}");
            bartosSwissAccount.AccountDeposit(200);
            Console.WriteLine($"Barto's Swiss account balance is now: {bartosSwissAccount.AccountBalance()}");

            Console.WriteLine("Final state");
            Console.WriteLine($"{bartosAccount.AccountName()} - {bartosAccount.AccountBalance()}");
            Console.WriteLine($"{bartosSwissAccount.AccountName()} - {bartosSwissAccount.AccountBalance()}");
        }

        static void MoneyTransfer()
        {
            Account mattsAcc = new Account("Matts account", 1000.0m, 3);
            Account myAcc = new Account("My account", 0.0m, 4);

            mattsAcc.AccountWithdrawal(100.00m);
            myAcc.AccountDeposit(100.00m);

            Console.WriteLine($"{mattsAcc.AccountName()} - {mattsAcc.AccountBalance()}");
            Console.WriteLine($"{myAcc.AccountName()} - {myAcc.AccountBalance()}");
        }
    }
}
