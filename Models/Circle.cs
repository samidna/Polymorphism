namespace Polymorphism_Abstraction.Models;

public class Circle : Shape
{
    public double Radius;
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}
