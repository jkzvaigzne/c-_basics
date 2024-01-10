namespace Account
{
    public partial class Account
    {
        private int _id;
        private string _accName;
        private decimal _accBalance;

        public Account(string accName, decimal accBalance, int id)
        {
            _id = id;
            _accName = accName;
            _accBalance = accBalance;
        }

        public void AccountWithdrawal(decimal amount) => _accBalance -= amount;

        public void AccountDeposit(decimal amount) => _accBalance += amount;

        public string AccountName() => _accName;

        public decimal AccountBalance() => _accBalance;
    }
}
