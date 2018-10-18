using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int countEngiines = int.Parse(Console.ReadLine());
            List<Engine> engine = new List<Engine>();
            for (int i = 0; i < countEngiines; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = tokens[0];
                string power = tokens[1];

                if (tokens.Length ==2)
                {
                    engine.Add(new Engine(model, power));

                }
                else if (tokens.Length == 3)
                {
                    string efficiency = tokens[2];

                    int temp;
                    bool check = int.TryParse(efficiency, out temp);
                    if (check)
                    {
                        engine.Add(new Engine(model, power, temp));
                    }
                    else
                    {
                        engine.Add(new Engine(model, power, efficiency));
                    }

                }

                else if (tokens.Length == 4)
                {
                    int displacement = int.Parse(tokens[2]);
                    string efficiency = tokens[3];
                    engine.Add(new Engine(model, power, displacement, efficiency));
                }
            }
            int countCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < countCars; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = tokens[0];
                string engineModel = tokens[1];
                var engine_Temp = new Engine(null, null);

                foreach (Engine item in engine)
                {
                    if (item.model == engineModel)
                    {
                        engine_Temp = item;
                    }
                }

                if (tokens.Length == 2)
                {
                    cars.Add(new Car(model, engine_Temp));
                }
                else if (tokens.Length == 3)
                {
                    string weightOrColor = tokens[2];
                    int weight;
                    bool check = int.TryParse(weightOrColor, out weight);
                    if (check)
                    {
                        cars.Add(new Car(model, engine_Temp, weight));
                    }
                    else
                    {
                        var color = tokens[2];
                        cars.Add(new Car(model, engine_Temp, color));
                    }
                }
                else if (tokens.Length == 4)
                {
                    int weight = int.Parse(tokens[2]);
                    string color = tokens[3];
                    cars.Add(new Car(model, engine_Temp, weight, color));

                }
            }
            foreach (Car car in cars)
            {
                Console.WriteLine(car.model+":");
                Console.WriteLine("  " + car.engine.model + ":");
                Console.WriteLine("    "+"Power: "+car.engine.power);
                var temp = car.engine.displacement == 0 ? "n/a" : car.engine.displacement.ToString();
                Console.WriteLine("    " + $"Displacement: {temp}");
                Console.WriteLine("    " + "Efficiency: " + car.engine.efficiency);
                var tempW = car.weight == 0 ? "n/a" : car.weight.ToString();
                Console.WriteLine($"  Weight: {tempW}");
                var tempC = car.color == null ? "n/a" : car.color.ToString();
                Console.WriteLine($"  Color: {tempC}");




            }

        }
    }
}
