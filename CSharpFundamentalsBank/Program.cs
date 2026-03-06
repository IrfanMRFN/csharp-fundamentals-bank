using CSharpFundamentalsBank;

Console.WriteLine("Setting up your account...");
// Create a new "Instance" of the BankAccount class
BankAccount myAccount = new BankAccount("Muhammad Irfan", 1500000m);

bool isRunning = true;

while (isRunning)
{
    Console.WriteLine($"\n--- Main Menu for {myAccount.AccountHolder} ---");
    Console.WriteLine($"Current Balance: Rp {myAccount.Balance}");
    Console.WriteLine("1. View Transaction History");
    Console.WriteLine("2. Withdraw Money");
    Console.WriteLine("3. Exit");
    Console.Write("Choose an option: ");

    string? userChoice = Console.ReadLine();

    switch (userChoice)
    {
        case "1":
            myAccount.PrintHistory();
            break;

        case "2":
            Console.Write("\nEnter amount to withdraw: Rp ");
            if (decimal.TryParse(Console.ReadLine(), out decimal amount))
            {
                // Call the method in the object
                bool success = myAccount.TryWithdraw(amount);
                if (success)
                {
                    Console.WriteLine("Withdrawal completed!");
                }
                else
                {
                    Console.WriteLine("Withdrawal failed! Insufficient funds.");
                }
            }
            else
            {
                Console.WriteLine("Invalid number format.");
            }
            break;

        case "3":
            isRunning = false;
            break;
    }
}