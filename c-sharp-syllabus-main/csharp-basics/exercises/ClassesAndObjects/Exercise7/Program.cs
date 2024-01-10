using System;

namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal startingBalance = GetValidationWithDecimal("How much money is in your account: ");
            decimal annualInterestRate = GetValidationWithDecimal("Input annual interest rate: ");
            int month = GetValidationWithInput("How long has the account been opened:");

            decimal totalDeposited = 0.0m;
            decimal totalWithdrawn = 0.0m;
            decimal interestEarned = 0.0m;

            SavingsAccount userSavingAccount1 = new SavingsAccount(startingBalance);
            userSavingAccount1.SetAnnualInterestRate(annualInterestRate);

            for (int i = 1; i <= month; i++)
            {
                decimal deposited = GetValidationWithDecimal($"Enter amount deposited for month {i}: ");
                userSavingAccount1.DepositMoney(deposited);
                totalDeposited += deposited;

                decimal withdraw = GetValidationWithDecimal($"Enter amount withdrawn for month {i}: ");
                userSavingAccount1.WithdrawMoney(withdraw);
                totalWithdrawn += withdraw;

                userSavingAccount1.AddMonthlyInterest();
                interestEarned += userSavingAccount1.GetMonthlyInterest();
            }

            Console.WriteLine($"Total deposited: ${totalDeposited:F2}");
            Console.WriteLine($"Total withdrawn: ${totalWithdrawn:F2}");
            Console.WriteLine($"Interest earned: ${interestEarned:F2}");
            Console.WriteLine($"Ending balance: ${userSavingAccount1.GetBalance():F2}");

            Console.ReadKey();
        }

        static decimal GetValidationWithDecimal(string message)
        {
            decimal result;

            while (true)
            {
                Console.Write(message);

                if (decimal.TryParse(Console.ReadLine(), out result) && result >= 0)
                {
                    return result;
                }

                Console.WriteLine("Please enter a valid positive number.");
            }
        }

        static int GetValidationWithInput(string message)
        {
            int result;

            while (true)
            {
                Console.Write(message);

                if (int.TryParse(Console.ReadLine(), out result) && result > 0)
                {
                    return result;
                }

                Console.WriteLine("Please enter a valid positive integer.");
            }
        }
    }
}
