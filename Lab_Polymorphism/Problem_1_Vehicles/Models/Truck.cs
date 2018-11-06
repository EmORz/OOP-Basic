using Problem_1_Vehicles.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_1_Vehicles.Models
{
    public class Truck : Vehile
    {
        private const double fueilExtra = 1.6;

        public Truck(double fuelQuantity, double fuelConsumation) : base(fuelQuantity, fuelConsumation+fueilExtra)
        {
        }
        public override void Drive(double distance)
        {
            if (this.fuelQuantity<this.fuelConsumation*distance)
            {
                throw new ArgumentException("Truck needs refueling");
            }
            base.Drive(distance);
        }
        public override void Refuel(double quantity)
        {
            const double presecntMiss = 0.95;
            base.Refuel(quantity*presecntMiss);
        }
        public override string ToString()
        {
            string message = $"{this.GetType().Name}: {this.fuelQuantity:f2}";
            return message;
        }
    }
}
