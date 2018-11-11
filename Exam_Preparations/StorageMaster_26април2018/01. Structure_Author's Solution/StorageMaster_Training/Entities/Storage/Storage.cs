using StorageMaster_Training.Entities.Products;
using StorageMaster_Training.Entities.Vechicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster_Training.Entities.Storage
{
    public abstract class Storage
    {
        private readonly List<Product> products;
        private readonly Vehicle[] garage;

        public Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.GarageSlots = garageSlots;


            this.garage = new Vehicle[garageSlots];
            this.products = new List<Product>();

            this.InittializateGarage(vehicles);
        }

        private void InittializateGarage(IEnumerable<Vehicle> vehicles)
        {
            var garageSlot = 0;
            foreach (var vehicle in vehicles)
            {
                this.garage[garageSlot++] = vehicle;
            }
        }

        public string Name { get; }

        public int Capacity { get; }

        public int GarageSlots { get; }

        public bool IsFull => this.products.Sum(x => x.Weight) >= this.Capacity;

        public IReadOnlyCollection<Vehicle> Garage => Array.AsReadOnly(this.garage);

        public IReadOnlyCollection<Product> Product => this.products.AsReadOnly();

        public Vehicle GetVehicle(int garageSlot)
        {          
            if (garageSlot>=this.garage.Length)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }
            var vechile = this.garage[garageSlot];

            if (vechile == null)
            {
                throw new InvalidOperationException("No vehicle in this garage slot!");
            }
            return vechile;
        }

        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            var vehicle = GetVehicle(garageSlot);
            var freeGarageSlot = deliveryLocation.Garage.Any(v => v == null);
            if (!freeGarageSlot)
            {
                throw new InvalidOperationException("No room in garage!");
            }
            this.garage[garageSlot] = null;

            var addSlot = deliveryLocation.AddVehicle(vehicle);

            return addSlot;
        }
        private int AddVehicle(Vehicle vehicle)
        {
            var freeGarageSlotIndex = Array.IndexOf(this.garage, null);
            this.garage[freeGarageSlotIndex] = vehicle;
            return freeGarageSlotIndex;
        }
        public int UnloadVehicle(int garageSlot)
        {
            if (this.IsFull)
            {
                throw new InvalidOperationException("Storage is full!");
            }
            var vehicle = GetVehicle(garageSlot);

            var countUnload = 0;
            while (!vehicle.IsEmpty && !this.IsFull)
            {
                var crat = vehicle.Unload();
                this.products.Add(crat);
                countUnload++;
            }
            return countUnload;
        }

    }
}
