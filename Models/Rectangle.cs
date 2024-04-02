namespace Polymorphism_Abstraction.Models;

public class Rectangle : Shape
{
    public double Width;
    public double Height;
    public override double CalculateArea()
    {
      return Width * Height;
    }
}
