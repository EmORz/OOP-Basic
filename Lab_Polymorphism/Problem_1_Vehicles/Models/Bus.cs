using Problem_1_Vehicles.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_1_Vehicles.Models
{
    public class Bus : Vehile, IDriveEmpty
    {
        private double emptyFuelConsumption;

        public Bus(double fuelQuantity, double fuelConsumation, double tankCapacity) : base(fuelQuantity, fuelConsumation+1.4, tankCapacity)
        {
            emptyFuelConsumption = fuelConsumation;
        }

        public override void Drive(double distance)
        {
            if (this.FuelQuantity<distance*this.FuelConsumation)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }
            base.Drive(distance);
        }

        public void DriveEmpty(double distance)
        {
            if (this.FuelQuantity < distance * this.FuelConsumation)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }
            this.DistanceTraveled += distance;
            this.FuelQuantity -= (emptyFuelConsumption * distance);
            string message = $"{this.GetType().Name} travelled {distance} km";
            Console.WriteLine(message);

        }

    }
}
