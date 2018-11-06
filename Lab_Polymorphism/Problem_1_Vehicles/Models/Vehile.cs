using Problem_1_Vehicles.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_1_Vehicles.Models
{
    public abstract class Vehile : IVechile
    {
        public Vehile(double fuelQuantity, double fuelConsumation)
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumation = fuelConsumation;
            this.DistanceTraveled = 0;
        }

        public double fuelQuantity { get; protected set; }

        public double fuelConsumation { get; protected set; }

        public double DistanceTraveled { get; protected set; }

        public virtual void Drive(double distance)
        {
            this.DistanceTraveled += distance;
            this.fuelQuantity -= (this.fuelConsumation*distance);
            string message = $"{this.GetType().Name} travelled {distance} km";
            Console.WriteLine(message);
        }

        public virtual void Refuel(double quantity)
        {
            this.fuelQuantity += quantity;
        }
        public override string ToString()
        {
            string message = $"{this.GetType().Name}: {this.fuelQuantity:f2}";
            return message;
        }
    }
}
