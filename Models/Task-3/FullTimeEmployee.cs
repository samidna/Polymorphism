namespace Polymorphism_Abstraction.Models.Task_3;

public class FullTimeEmployee : Employee
{
    public FullTimeEmployee(int employeeId,string name,double basicSalary)
    {
        EmployeeId = employeeId;
        Name = name;
        BasicSalary = basicSalary;
    }

    public override void CalculateSalary()
    {
        BasicSalary *= 2;
        Console.WriteLine($"Employee current salary : {BasicSalary}");
    }
}
