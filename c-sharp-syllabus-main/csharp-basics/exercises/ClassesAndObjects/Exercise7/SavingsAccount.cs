namespace Exercise7
{
    public class SavingsAccount
    {
        public decimal AccountAnnualInterestRate { get; private set; }
        private decimal _balance;

        public SavingsAccount(decimal savings) => _balance = savings;

        public void WithdrawMoney(decimal amount) => _balance -= amount;

        public void DepositMoney(decimal amount) => _balance += amount;

        public void AddMonthlyInterest() => _balance += GetMonthlyInterest();

        public decimal GetMonthlyInterest() => AccountAnnualInterestRate / 12 * _balance;

        public void SetAnnualInterestRate(decimal annualInterestRate) => AccountAnnualInterestRate = annualInterestRate;

        public decimal GetBalance() => _balance;
    }
}
