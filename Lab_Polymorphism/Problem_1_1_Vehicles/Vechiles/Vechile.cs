using Problem_1_1_Vehicles.Contracts;
using System;


    public abstract class Vechile : IVehicles
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        protected Vechile(double fuelConsumption, double fuelQuantity, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
           this.FuelConsumption = fuelConsumption;
           this.FuelQuantity = fuelQuantity;
        }
        public bool IsVehicleEmty { get; set; }
        public double TankCapacity
        {
            get { return tankCapacity; }
            set { tankCapacity = value; }
        }
        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }
        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set
            {
                if (value>this.TankCapacity)
                {
                    value = 0;
                }
                fuelQuantity = value;
            }
        }


        public virtual void Driven(double distance)
        {
            var currentFuelConsumpation = this.FuelConsumption;
            double needFuel = distance * this.FuelConsumption;
            if (this.FuelQuantity < needFuel)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }
            this.FuelQuantity -= needFuel;
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
        }

        public virtual void Refueled(double litters)
        {
            if (litters<=0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (this.FuelQuantity+litters>this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {litters} fuel in the tank");
            }

            this.FuelQuantity += litters;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }

