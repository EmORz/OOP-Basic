using Ferrari;
using System;

namespace FerrariN.Core
{
    public class Engine
    {
        public void Run()
        {
            string driverName = Console.ReadLine();

            ICar ferrari = new Ferrari(driverName);
            Console.WriteLine(ferrari.ToString());
        }
    }
}
