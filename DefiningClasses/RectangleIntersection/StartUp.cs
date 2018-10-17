using System;
using System.Collections.Generic;
using System.Linq;

namespace RectangleIntersection
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var listRect = new List<Rectangle>();
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numberOfRectangles = nums[0];
            var intersectionsChecks = nums[1];
            //
            for (int i = 0; i < numberOfRectangles; i++)
            {
                string[] input = Console.ReadLine().Split();
                var id = input[0];
                var height = double.Parse(input[1]);
                var width = double.Parse(input[2]);
                var x = double.Parse(input[3]);
                var y = double.Parse(input[4]);
                //
                Rectangle rectangle = new Rectangle(id, width, height, x, y);
                listRect.Add(rectangle);
            }
            //
            for (int j = 0; j < intersectionsChecks; j++)
            {
                string[] input = Console.ReadLine().Split();
                var firstId = input[0];
                var secondId = input[1];
                //
                var firstRect = listRect.FirstOrDefault(x => x.Id == firstId);
                var secondRect = listRect.FirstOrDefault(x => x.Id == secondId);

                if (firstRect.Intersect(secondRect))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }



            }


        }
    }
}
