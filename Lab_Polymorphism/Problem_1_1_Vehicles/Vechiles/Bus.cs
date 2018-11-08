using Problem_1_1_Vehicles;
using System;


    public class Bus : Vechile
    {
        private const double airConditionConstruction = 1.4;

        public Bus(double fuelConsumption, double fuelQuantity, double tankCapacity)
            : base(fuelConsumption, fuelQuantity, tankCapacity)
        {
        }

        public override void Driven(double distance)
        {
            var currentFuelConsumpation = this.FuelConsumption;
            if (!IsVehicleEmty)
            {
                currentFuelConsumpation += airConditionConstruction;
            }
            double needFuel = distance * currentFuelConsumpation;
            if (this.FuelQuantity < needFuel)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }
            this.FuelQuantity -= needFuel;
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
        }
    }

