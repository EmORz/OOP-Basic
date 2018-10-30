using System;

namespace Shapes
{
    public class Circle : IDrawable
    {
        private double radius;
        public Circle(double radius)
        {
            this.Raduis = radius;
        }
        public double Raduis
        {
            get { return radius; }
            private set { radius = value; }
        }

        public void Draw()
        {
            double rIn = this.Raduis - 0.4;
            double rOut = this.Raduis + 0.4;

            for (double y = this.Raduis; y >= -this.Raduis; y--)
            {
                for (double x = -this.Raduis; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    bool isInside = value >= rIn * rIn && value <= rOut * rOut;
                    if (isInside)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
