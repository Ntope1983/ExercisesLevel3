public class BankAccount
{
    public decimal Balance { get; private set; } // PascalCase

    public BankAccount(decimal initialBalance)
    {
        if (initialBalance < 0)
            throw new ArgumentException("Initial balance cannot be negative.");

        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit must be positive!");
            return;
        }

        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdraw must be positive!");
            return;
        }

        if (Balance < amount)
        {
            throw new Issufficientfundexception("Not enough funds to complete this withdrawal.");
        }

        Balance -= amount;



    }
}