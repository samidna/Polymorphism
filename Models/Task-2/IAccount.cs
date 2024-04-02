namespace Polymorphism_Abstraction.Models.Task_2;

public interface IAccount
{
    void Deposit(double amount);
    void WithDraw(double amount);
    double CalculateInterest();
}
