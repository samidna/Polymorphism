namespace Polymorphism_Abstraction.Models;

public class Triangle : Shape
{
    public double Width;
    public double Height;
    public override double CalculateArea()
    {
      return (Width * Height)/2;
    }
}
