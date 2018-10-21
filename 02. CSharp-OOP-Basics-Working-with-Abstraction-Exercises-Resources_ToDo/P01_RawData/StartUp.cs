using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_RawData
{

    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = parameters[0];
                //
                int engineSpeed = int.Parse(parameters[1]);
                int enginePower = int.Parse(parameters[2]);
                Engine engine = new Engine(engineSpeed, enginePower);
                //
                int cargoWeight = int.Parse(parameters[3]);
                string cargoType = parameters[4];
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                //
                double tire1Pressure = double.Parse(parameters[5]);
                int tire1age = int.Parse(parameters[6]);
                Tire tire1 = new Tire(tire1Pressure, tire1age);
                double tire2Pressure = double.Parse(parameters[7]);
                int tire2age = int.Parse(parameters[8]);
                Tire tire2 = new Tire(tire2Pressure, tire2age);
                double tire3Pressure = double.Parse(parameters[9]);
                int tire3age = int.Parse(parameters[10]);
                Tire tire3 = new Tire(tire3Pressure, tire3age);
                double tire4Pressure = double.Parse(parameters[11]);
                int tire4age = int.Parse(parameters[12]);
                Tire tire4 = new Tire(tire4Pressure, tire4age);
                List<Tire> list = new List<Tire>();
                list.Add(tire1);
                list.Add(tire2);
                list.Add(tire3);
                list.Add(tire4);          
                //
                cars.Add(new Car(model, engine, cargo, list));
            }
            string command = Console.ReadLine();
            if (command == "fragile")
            {
               cars.Where(x => x.cargo.Type == "fragile").Where(y => y.tire.Any(z => z.Pessure < 1)).Select(x => x.model).ToList().ForEach(x => Console.WriteLine(x));            
            }
            else if (command == "flamable")
            {
               cars.Where(x => x.cargo.Type == command).Where(y => y.engine.Power>250).Select(x => x.model).ToList().ForEach(x => Console.WriteLine(x));


            }
        }
    }
}
