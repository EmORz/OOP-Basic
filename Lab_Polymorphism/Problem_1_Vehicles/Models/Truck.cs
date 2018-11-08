using Problem_1_Vehicles.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_1_Vehicles.Models
{
    public class Truck : Vehile
    {
        private const double fueilExtra = 1.6;

        public Truck(double fuelQuantity, double fuelConsumation, double tankCapacity) : base(fuelQuantity, fuelConsumation + fueilExtra, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            if (this.FuelQuantity<this.FuelConsumation*distance)
            {
                throw new ArgumentException("Truck needs refueling");
            }
            base.Drive(distance);
        }
        public override void Refuel(double quantity)
        {
            const double presecntMiss = 0.05;
            base.Refuel(quantity);
            this.FuelQuantity -= (quantity*presecntMiss);
        }
        public override string ToString()
        {
            string message = $"{this.GetType().Name}: {this.FuelQuantity:f2}";
            return message;
        }
    }
}
