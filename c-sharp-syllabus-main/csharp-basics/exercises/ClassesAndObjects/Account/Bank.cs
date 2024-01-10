namespace Account
{
    public partial class Account
    {
        public static partial class Bank
        {
            public static void Transfer(Account source, Account destination, decimal howMuch)
            {
                source.AccountWithdrawal(howMuch);
                destination.AccountDeposit(howMuch);
            }
        }
    }
}
