namespace Polymorphism_Abstraction.Models.Task_2;

public abstract class Account
{
    public string AccountNumber { get; set; }
    public double Balance { get; set; }

    public abstract void ShowAccountDetails();
}
