using System;

namespace Shapes
{
    public class Circle : IDrawable
    {
        private int? radius;
        public Circle(int? radius)
        {
            this.Radius = radius;
        }
        public int? Radius
        {
            get { return radius; }
            private set
            {
                if (value<1)
                {
                    throw new ArgumentException("Radius must be  minimum 1");

                }
                this.radius = value;

            }
        }

        public void Draw()
        {
            double? rIn = this.Radius - 0.4;
            double? rOut = this.Radius + 0.4;

            for (double? y = this.Radius; y >= -this.Radius; --y)
            {
                for (double? x = -this.Radius; x < rOut; x += 0.5)
                {
                    double? value = x * x + y * y;
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
