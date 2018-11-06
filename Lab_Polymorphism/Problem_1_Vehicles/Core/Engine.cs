using Problem_1_Vehicles.Contracts;
using Problem_1_Vehicles.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_1_Vehicles.Core
{
    public class Engine
    {
        public void Run()
        {
            string[] carArgs = Console.ReadLine().Split();
            string[] truckArgs = Console.ReadLine().Split();
            //
            //fuel and distance
            var fuelCarQuantity = double.Parse(carArgs[1]);
            var fuelCarConsumation = double.Parse(carArgs[2]);
            var fuelTruckQuantity = double.Parse(truckArgs[1]);
            var fuelTruckConsumation = double.Parse(truckArgs[2]);
            //
            IVechile car = new Car(fuelCarQuantity,fuelCarConsumation);
            IVechile truck = new Truck(fuelTruckQuantity, fuelTruckConsumation);
            //
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                string typeVechile = input[1];
                double distane = double.Parse(input[2]);

                try
                {
                    switch (command)
                    {
                        case "Drive":
                            switch (typeVechile)
                            {
                                case "Car":
                                    car.Drive(distane);
                                    break;
                                case "Truck":
                                    truck.Drive(distane);
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case "Refuel":
                            switch (typeVechile)
                            {
                                case "Car":
                                    car.Refuel(distane);
                                    break;
                                case "Truck":
                                    truck.Refuel(distane);
                                    break;
                                default:
                                    break;
                            }
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            Console.WriteLine(car);
            Console.WriteLine(truck);

        }
    }
}
