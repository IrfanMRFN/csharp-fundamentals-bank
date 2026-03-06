namespace CSharpFundamentalsBank;

public class BankAccount
{
    // Properties
    public string AccountHolder { get; private set; }
    public decimal Balance { get; private set; }
    private readonly List<decimal> _transactionHistory;

    // Constructor
    public BankAccount(string accountHolder, decimal initialBalance)
    {
        AccountHolder = accountHolder;
        Balance = initialBalance;
        _transactionHistory = [ initialBalance ];
    }

    // Methods
    public void PrintHistory()
    {
        Console.WriteLine("\n--- Transaction History ---");
        int counter = 1;
        foreach (decimal transaction in _transactionHistory)
        {
            if (transaction >= 0)
                Console.WriteLine($"{counter}. +{transaction}");
            else
                Console.WriteLine($"{counter}. {transaction}");
            
            counter++;
        }
    }

    public bool TryWithdraw(decimal amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            _transactionHistory.Add(-amount);
            return true;
        }
        else
        {
            return false;
        }
    }

    public void PrintDepositReport()
    {
        Console.WriteLine("\n--- Deposit Report ---");
        var deposits = _transactionHistory.Where(x => x > 0);
        int counter = 1;
        foreach (decimal deposit in deposits)
        {
            Console.WriteLine($"{counter}. +{deposit}");
            counter++;
        }
        Console.WriteLine($"Total deposited amount: Rp {deposits.Sum()}");
    }
}