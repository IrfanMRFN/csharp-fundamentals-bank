// Setup data
string accountHolder = "Muhammad Irfan";
decimal accountBalance = 1500000m;
List<decimal> transactionHistory = [ 1500000m ]; 
bool isRunning = true;

Console.WriteLine($"Welcome back to C# Bank, {accountHolder}!");

// The Application Loop
while (isRunning)
{
    Console.WriteLine("\n--- Main Menu ---");
    Console.WriteLine("1. View Balance & Transaction History");
    Console.WriteLine("2. Withdraw Money");
    Console.WriteLine("3. Exit");
    Console.Write("Choose an option (1-3): ");

    // Read the user's keyboard input
    string? userChoice = Console.ReadLine();

    switch (userChoice)
    {
        case "1":
            Console.WriteLine($"\nCurrent Balance: Rp {accountBalance}");
            Console.WriteLine("--- Transaction History ---");
            
            // Displaying transactions
            int counter = 1;
            foreach (decimal transaction in transactionHistory)
            {
                if (transaction >= 0)
                    Console.WriteLine($"{counter}. +{transaction}");
                else
                    Console.WriteLine($"{counter}. {transaction}");
                counter++;
            }
            break;

        case "2":
            Console.Write("\nEnter amount to withdraw: Rp ");

            // Convert text input into decimal
            bool isValid = decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount);

            if (!isValid)
            {
                Console.WriteLine($"Transaction failed!");
                Console.WriteLine($"Input must be a valid number.");
                break;
            }

            if (withdrawAmount <= accountBalance)
            {
                accountBalance -= withdrawAmount;

                // Adding withdraw transaction into transaction history
                transactionHistory.Add(-withdrawAmount);
                Console.WriteLine($"Withdraw completed!");
                Console.WriteLine($"Your new balance is: Rp {accountBalance}");
            }
            else
            {
                Console.WriteLine($"Withdraw failed!");
                Console.WriteLine($"Insufficient funds.");
            }
            break;

        case "3":
            Console.WriteLine("\nThank you for banking with us. Goodbye!");
            isRunning = false; 
            break;

        default:
            Console.WriteLine("\nInvalid choice. Please type 1, 2, or 3.");
            break;
    }
}