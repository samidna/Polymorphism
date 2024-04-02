namespace Polymorphism_Abstraction.Models.Task_3;

public abstract class Employee
{
    public string Name { get; set; }
    public int EmployeeId { get; set; }
    public double BasicSalary { get; set; }

    public abstract void CalculateSalary();
}
