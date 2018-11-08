using Problem_1_Vehicles.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_1_Vehicles.Models
{
    public abstract class Vehile : IVechile
    {
        private double fuelQuantity;
        private double fuelConsumation;
        private double distanceTraveled;
        private double tankCapacity;


        protected Vehile(double fuelQuantity, double fuelConsumation, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumation = fuelConsumation;
            this.DistanceTraveled =0;
            this.TankCapacity = tankCapacity;
        }
        public double FuelQuantity
        {
            get { return fuelQuantity; }
            protected set
            {
                if (value > this.TankCapacity)
                {
                    fuelQuantity = 0;
                }
                fuelQuantity = value;
            }
        }
        public double FuelConsumation { get => fuelConsumation; set => fuelConsumation = value; }
        public double DistanceTraveled { get => distanceTraveled; set => distanceTraveled = value; }
        public double TankCapacity { get => tankCapacity; set => tankCapacity = value; }

        public virtual void Drive(double distance)
        {
            this.DistanceTraveled += distance;
            this.FuelQuantity -= (this.FuelConsumation * distance);
            string message = $"{this.GetType().Name} travelled {distance} km";
            Console.WriteLine(message);
        }

        public void DriveEmpty(double distance)
        {
            throw new NotImplementedException();
        }

        public virtual void Refuel(double quantity)
        {
            if (quantity<=0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (this.FuelQuantity+quantity> this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {quantity} fuel in the tank");
            }
            this.FuelQuantity += quantity;
        }
        public override string ToString()
        {
            string message = $"{this.GetType().Name}: {this.FuelQuantity:f2}";
            return message;
        }
    }
}
