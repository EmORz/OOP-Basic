using System;

namespace Problem_1_Vehicles.Models
{
    public class Car : Vehile
    {
        private const double fueilExtra = 0.9;

        public Car(double fuelQuantity, double fuelConsumation) : base(fuelQuantity, fuelConsumation+fueilExtra)
        {
        }
        public override void Drive(double distance)
        {
            if (this.fuelQuantity<this.fuelConsumation*distance)
            {
                throw new ArgumentException("Car needs refueling");
            }
            base.Drive(distance);
        }
        public override void Refuel(double quantity)
        {
            base.Refuel(quantity);
        }
    }
}
