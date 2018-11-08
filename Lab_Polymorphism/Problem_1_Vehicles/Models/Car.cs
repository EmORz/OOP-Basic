using System;

namespace Problem_1_Vehicles.Models
{
    public class Car : Vehile
    {
        private const double fueilExtra = 0.9;

        public Car(double fuelQuantity, double fuelConsumation, double tankCapacity) : base(fuelQuantity, fuelConsumation+fueilExtra, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            if (this.FuelQuantity<this.FuelConsumation*distance)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }
            base.Drive(distance);
        }
        //public override void Refuel(double quantity)
        //{
        //    base.Refuel(quantity);
        //}
    }
}
