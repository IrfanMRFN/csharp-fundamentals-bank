// Variables
string accountHolder = "Muhammad Irfan";
decimal accountBalance = 1500000m;
bool isActive = true;
decimal withdrawAmount = 500000m;

// Output & String Interpolation
Console.WriteLine($"Welcome to the C# Bank, {accountHolder}!");
Console.WriteLine($"Your current balance is: Rp {accountBalance}");

// If/Else checks
if (isActive)
{
    if (withdrawAmount <= accountBalance)
    {
        accountBalance -= withdrawAmount;
        Console.WriteLine($"Withdraw completed!");
        Console.WriteLine($"Your new balance is: Rp {accountBalance}");
    }
    else
    {
        Console.WriteLine($"Withdraw failed!");
        Console.WriteLine($"Insufficient funds.");
    }
}
else
{
    Console.WriteLine($"Transaction failed!");
    Console.WriteLine($"Inactive account.");
}