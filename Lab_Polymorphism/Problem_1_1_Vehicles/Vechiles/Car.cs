
using Problem_1_1_Vehicles;

public class Car : Vechile
    {
        private const double airConditionConstruction = 0.9;

        public Car(double fuelConsumption, double fuelQuantity, double tankCapacity) 
            : base(fuelConsumption, fuelQuantity, tankCapacity)
        {
            this.FuelConsumption += airConditionConstruction;
        }

    }

