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
            string[] busArgs = Console.ReadLine().Split();
            //
            var fuelCarQuantity = double.Parse(carArgs[1]);
            var fuelCarConsumation = double.Parse(carArgs[2]);
            var fuelCarTank = double.Parse(carArgs[3]);

            var fuelTruckQuantity = double.Parse(truckArgs[1]);
            var fuelTruckConsumation = double.Parse(truckArgs[2]);
            var fuelTruckTank = double.Parse(truckArgs[3]);


            var fuelBusQuantity = double.Parse(busArgs[1]);
            var fuelBusConsumation = double.Parse(busArgs[2]);
            var fuelBusTank = double.Parse(busArgs[3]);

            //
            IVechile car = new Car(fuelCarQuantity,fuelCarConsumation, fuelCarTank);
            IVechile truck = new Truck(fuelTruckQuantity, fuelTruckConsumation, fuelTruckTank);
            IVechile bus = new Bus(fuelBusQuantity, fuelBusConsumation, fuelBusTank)
;            //
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
                        case "DriveEmpty":
                            bus.DriveEmpty(distane);
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
            Console.WriteLine(bus);

        }
    }
}
