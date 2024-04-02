namespace Polymorphism_Abstraction.Models.Task_2;

public class SavingAccount : Account, IAccount
{
    public SavingAccount(double balance)
    {
        AccountNumber = Guid.NewGuid().ToString();
        Balance = balance;
    }
    public double CalculateInterest()
    {
        throw new NotImplementedException();
    }

    public void Deposit(double amount)
    {
        if (amount<=0) Console.WriteLine("Amount must be more than 0");
        else Balance += amount;
    }

    public override void ShowAccountDetails()
    {
        Console.WriteLine($"Account number : {AccountNumber}\nBalance : {Balance}");
    }

    public void WithDraw(double amount)
    {
        if (amount>Balance) Console.WriteLine("Amount must be less than balance");
        else Balance -= amount;
    }
}
