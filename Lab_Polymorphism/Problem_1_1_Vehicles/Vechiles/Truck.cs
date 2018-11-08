using Problem_1_1_Vehicles;
using System;

    public class Truck : Vechile
    {
        private const double airConditionConstruction = 1.6;

        public Truck(double fuelConsumption, double fuelQuantity, double tankCapacity) : base(fuelConsumption, fuelQuantity, tankCapacity)
        {
            this.FuelConsumption += airConditionConstruction;
        }

        public override void Refueled(double litters)
        {
            if (litters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (this.FuelQuantity + litters > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {litters} fuel in the tank");
            }

            this.FuelQuantity += litters*0.95;
        }


    }

