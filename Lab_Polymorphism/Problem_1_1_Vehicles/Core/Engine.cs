
using Problem_1_1_Vehicles.Contracts;
using System;

public class Engine
    {
        public void Run()
        {
            //Car 15 0.3
            //Truck 100 0.9
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

                IVehicles car = new Car(fuelCarConsumation, fuelCarQuantity, fuelCarTank);
                IVehicles truck = new Truck(fuelTruckConsumation, fuelTruckQuantity, fuelTruckTank);
                IVehicles bus = new Bus(fuelBusConsumation, fuelBusQuantity, fuelBusTank);
                //
                int count = int.Parse(Console.ReadLine());

                for (int i = 0; i < count; i++)
                {
                    //Drive Car 9
                    try
                    {
                        string[] inptArgs = Console.ReadLine().Split();
                        string command = inptArgs[0];
                        string type = inptArgs[1];
                        double parameter = double.Parse(inptArgs[2]);
                        //
                        if (command == "Drive")
                        {
                            if (type == "Car")
                            {
                                car.Driven(parameter);
                            }
                            else if (type == "Truck")
                            {
                                truck.Driven(parameter);
                            }
                            else if (type == "Bus")
                            {
                                bus.Driven(parameter);
                            }
                        }
                        else if (command == "Refuel")
                        {
                            if (type == "Car")
                            {
                                car.Refueled(parameter);
                            }
                            else if (type == "Truck")
                            {
                                truck.Refueled(parameter);
                            }
                            else if (type == "Bus")
                            {
                                bus.IsVehicleEmty = false;
                                bus.Refueled(parameter);
                            }
                        }
                        else if (command == "DriveEmpty")
                        {
                            bus.IsVehicleEmty = true;
                            bus.Driven(parameter);
                        }
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                    }
                }
                Console.WriteLine(car);
                Console.WriteLine(truck);
                Console.WriteLine(bus);
            
          
        
    }
}
