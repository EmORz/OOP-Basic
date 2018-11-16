using StorageMaster.Entities.Products;
using StorageMaster.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster.Entities.Storages
{
    public abstract class Storage
    {
        private string name;
        private int capacity;
        private int garageSlots;
        private Vehicle[] garage;
        private List<Product> products;

        protected Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.GarageSlots = garageSlots;

            this.products = new List<Product>();
            this.garage = new Vehicle[this.GarageSlots];

            this.FillGarageWithInitialVehicle(vehicles);

        }    

        public IReadOnlyCollection<Product> Products => this.products.AsReadOnly();
        public IReadOnlyCollection<Vehicle> Garage => Array.AsReadOnly(this.garage);
        public bool IsFull => this.products.Sum(p => p.Weight) >= this.Capacity;
        public int GarageSlots
        {
            get { return garageSlots; }
            private set { garageSlots = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            private set { capacity = value; }
        }
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        //Methods

        public Vehicle GetVehicle(int garageSlot)
        {
            if (garageSlot>=this.GarageSlots)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }
            var vechicle = this.garage[garageSlot];
            if (vechicle == null)
            {
                throw new InvalidOperationException("No vehicle in this garage slot!");
            }

            return vechicle;
        }

        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            var vechile = this.GetVehicle(garageSlot);
            var index = deliveryLocation.AddGarageInitialVehicle(vechile);
            this.garage[garageSlot] = null;
            return index;
        }

        public int UnloadVehicle(int garageSlot)
        {
            if (this.IsFull)
            {
                throw new InvalidOperationException("Storage is full!");
            }
            var vechie = this.GetVehicle(garageSlot);
            var counterUnload = 0;
            while (!this.IsFull || !vechie.IsEmpty)
            {
                var product = vechie.Unload();
                this.products.Add(product);
                counterUnload++;
            }
            return counterUnload;
        }



        //Inner methods
        private void FillGarageWithInitialVehicle(IEnumerable<Vehicle> vehicles)
        {
            var count = 0;
            foreach (Vehicle vehicle in vehicles)
            {
                this.garage[count++] = vehicle;
            }
        }
        private int AddGarageInitialVehicle(Vehicle vechile)
        {
            var freeGarageIndex = Array.IndexOf(garage, null);

            if (freeGarageIndex == -1)
            {
                throw new InvalidOperationException("No room in garage!");
            }
            this.garage[freeGarageIndex] = vechile;
            return freeGarageIndex;
        }

    }
}
