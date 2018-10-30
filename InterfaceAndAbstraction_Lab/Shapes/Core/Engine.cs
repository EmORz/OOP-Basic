using System;

namespace Shapes.Core
{
    public class Engine
    {
        public void Run()
        {
            Double raduis = Double.Parse(Console.ReadLine());
            IDrawable circle = new Circle(raduis);        


            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            IDrawable rectangle = new Rectangle(height, width);
            circle.Draw();
            rectangle.Draw();
        }
    }
}
