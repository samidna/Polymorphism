
using Polymorphism_Abstraction.Models;
using Polymorphism_Abstraction.Models.Task_2;
using Polymorphism_Abstraction.Models.Task_3;
using Polymorphism_Abstraction.Models.Task_4;

#region TASK-1
Circle circle = new Circle();
circle.Radius = 5;
Console.WriteLine(circle.CalculateArea());

Rectangle rectangle = new();
rectangle.Width = 5;
rectangle.Height = 3;
Console.WriteLine(rectangle.CalculateArea());

Square square = new Square();
square.Width = 6;
Console.WriteLine(square.CalculateArea());
#endregion

#region TASK-2
CuurentAccount ca = new(5000);
SavingAccount sa = new(2000);

ca.ShowAccountDetails();
sa.ShowAccountDetails();
#endregion

#region TASK-3
FullTimeEmployee fte = new(2, "Johan", 800);
PartTimeEmployee pte = new(3, "Enna", 800);

fte.CalculateSalary();
pte.CalculateSalary();
#endregion

#region TASK-4
Book book = new("test", "admin", 2);
Dvd dvd = new("test1", "admin1", 0);
Magazine magazine = new("test2", "admin2", 3);

dvd.CheckOut();
book.CheckOut();
magazine.CheckOut();

dvd.Return();
magazine.Return();
book.Return();

#endregion