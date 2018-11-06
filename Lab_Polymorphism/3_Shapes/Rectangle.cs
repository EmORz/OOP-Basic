
using Shapes;

public class Rectangle : Shape
{
    double sideA;
    double sideB;

    public Rectangle(double sideA, double sideB)
    {
        this.sideA = sideA;
        this.sideB = sideB;
    }

    public override double CalculateArea()
    {
        var area = this.sideA * this.sideB;
        return area;
    }

    public override double CalculatePerimeter()
    {
        var perimeter = 2 * (this.sideB + this.sideA);
        return perimeter;
    }
    public sealed override string Draw()
    {
        return base.Draw() + this.GetType().Name;
    }
}

