namespace Accounts
{
    public class Account
    {
        public string Name { get; private set; }
        public double Balance { get; private set; }

        public Account(string name, double initialBalance)
        {
            if (initialBalance < 0)
            {
                throw new ArgumentException("Initial balance cannot be negative.");
            }

            Name = name;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }

            Balance += amount;
        }

        public void Withdrawal(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.");
            }

            if (amount > Balance)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }

            Balance -= amount;
        }
    }

}