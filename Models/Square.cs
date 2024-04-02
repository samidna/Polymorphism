namespace Polymorphism_Abstraction.Models;

public class Square : Shape
{
    public double Width;
    public override double CalculateArea()
    {
        return Width * Width;
    }
}
