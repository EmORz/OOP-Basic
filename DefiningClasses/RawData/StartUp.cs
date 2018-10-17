using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Car[] cars = new Car[n];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                var model = input[0];
                var engineSpeed = int.Parse(input[1]);
                var enginePower = int.Parse(input[2]);
                var cargoWeight = int.Parse(input[3]);
                var cargoType = input[4];
                var Tire1Pressure = double.Parse(input[5]);
                var Tire1Age = int.Parse(input[6]);
                var Tire2Pressure = double.Parse(input[7]);
                var Tire2Age = int.Parse(input[8]);
                var Tire3Pressure = double.Parse(input[9]);
                var Tire3Age = int.Parse(input[10]);
                var Tire4Pressure = double.Parse(input[11]);
                var Tire4Age = int.Parse(input[12]);

                cars[i] = new Car(model, new Engine(enginePower, engineSpeed), new List<Tire> { new Tire(Tire1Age, Tire1Pressure), new Tire(Tire2Age, Tire2Pressure), new Tire(Tire3Age, Tire3Pressure), new Tire(Tire4Age, Tire4Pressure) }, 
                    new Cargo(cargoType, cargoWeight));

            }
            string typeOfPackedge = Console.ReadLine();

            if (typeOfPackedge == "fragile")
            {
                cars.Where(x => x.cargo.type == "fragile").Where(x => x.tire.Any(c => c.tirePresure < 1)).Select(x => x.model).ToList().ForEach(x => Console.WriteLine(x)); ;
            }
            else if (typeOfPackedge == "flamable")
            {
                cars.Where(x => x.cargo.type == "flamable").Where(x => x.engine.power > 250).Select(x => x.model).ToList().ForEach(x => Console.WriteLine(x));
            }
        }
    }
}
