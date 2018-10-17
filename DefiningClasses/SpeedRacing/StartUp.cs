using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        
        static void Main(string[] args)
        {
            int numOfCars = int.Parse(Console.ReadLine());
            var cars = new Cars[numOfCars];
            for (int i = 0; i < numOfCars; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string model = tokens[0];
                double fuelAmount = double.Parse(tokens[1]);
                double FuelConsumptionFor1km = double.Parse(tokens[2]);
                //
                cars[i] = (new Cars(model, fuelAmount, FuelConsumptionFor1km));
            }
            DriveCars(cars);
            //
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.model} {car.fuelAmount:f2} {car.traveledDistance}");
            }
        }

        private static void DriveCars(Cars[] cars)
        {
            string commands;
            while ((commands = Console.ReadLine()) != "End")
            {
                string[] commmandsArgs = commands.Split();
                string carModel = commmandsArgs[1];
                double amountOfKm = double.Parse(commmandsArgs[2]);
                //
                cars.Where(car => car.model == carModel).ToList().ForEach(c => c.Drive(amountOfKm));

                
            }
        }

    }
}
