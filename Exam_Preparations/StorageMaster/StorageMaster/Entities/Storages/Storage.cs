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
        private List<Product> products;
        private Vehicle[] garage;
        public Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.GarageSlots = garageSlots;

            this.products = new List<Product>();
            this.garage = new Vehicle[this.GarageSlots];

            this.FillGarageWithInitialVehicle(vehicles);
        }        

        public string Name { get; private set; }
        public int Capacity { get; private set; }
        public int GarageSlots { get; private set; }

        public bool IsFull => this.products.Sum(w => w.Weight) >= this.Capacity;

        public IReadOnlyCollection<Product> Products => this.products.AsReadOnly();
        public IReadOnlyCollection<Vehicle> Garage => Array.AsReadOnly(this.garage);

        //Methods
        public Vehicle GetVehicle(int garageSlot)
        {
            if (garageSlot>=this.GarageSlots)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }
            var vehicle = this.garage[garageSlot];
            if (vehicle == null)
            {
                throw new InvalidOperationException("No vehicle in this garage slot!");
            }
            return vehicle;
        }
        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            var vechile = this.GetVehicle(garageSlot);
            int index = deliveryLocation.AddGarageInitialVehicle(vechile);
            this.garage[garageSlot] = null;
            return index;
        }
        public int UnloadVehicle(int garageSlot)
        {
            if (this.IsFull)
            {
                throw new InvalidOperationException("Storage is full!.");
            }
            var vehicle = this.GetVehicle(garageSlot);
            var unloadedProduct = 0;
            while (!this.IsFull && !vehicle.IsEmpty)
            {
                var product = vehicle.Unload();
                products.Add(product);
                unloadedProduct++;
            }
            return unloadedProduct;
        }

        //Inner method - fill garage with vehicles
        private void FillGarageWithInitialVehicle(IEnumerable<Vehicle> vehicles)
        {
            var index = 0;
            foreach (Vehicle vehicle in vehicles)
            {
                this.garage[index++] = vehicle;
            }
        }

        private int AddGarageInitialVehicle(Vehicle vehicle)
        {
            int freeGarageSlotIndex = Array.IndexOf(garage, null);

            if (freeGarageSlotIndex == -1)
            {
                throw new InvalidOperationException("No room in garage!");
            }
            this.garage[freeGarageSlotIndex] = vehicle;
            return freeGarageSlotIndex;
        }




    }
}
