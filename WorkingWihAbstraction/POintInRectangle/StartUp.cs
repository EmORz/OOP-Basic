using System;
using System.Linq;

namespace PointInRectangle
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] coordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int x = tokens[0];
                int y = tokens[1];


                Rectangle rectangle = new Rectangle(new Point(coordinates[0], coordinates[1]), new Point(coordinates[2], coordinates[3]));
                bool isInside = rectangle.Contains(new Point(x, y));
                if (isInside)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
        }
    }
}
