using System;

namespace Shapes.Core
{
    public class Engine
    {
        public void Run()
        {
            try
            {
                int raduis = int.Parse(Console.ReadLine());
                int? width = int.Parse(Console.ReadLine());
                int? height = int.Parse(Console.ReadLine());
                
                IDrawable circle = new Circle(raduis);
                circle.Draw();
            
                IDrawable rectangle = new Rectangle(height, width);
                rectangle.Draw();
                
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        
        }
    }
}
