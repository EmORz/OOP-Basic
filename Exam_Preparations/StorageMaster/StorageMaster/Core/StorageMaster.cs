using StorageMaster.Entities.Products;
using StorageMaster.Entities.Storages;
using StorageMaster.Entities.Vehicles;
using StorageMaster.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster.Core
{
    public class StorageMaster
    {
        private Dictionary<string, Stack<Product>> products;
        private ProductFactory productFactory;
        private StorageFactory storageFactory;
        private Vehicle currentVehicle;

        private Dictionary<string, Storage> storages;

        public StorageMaster()
        {
            this.productFactory = new ProductFactory();
            this.storageFactory = new StorageFactory();
            this.products = new Dictionary<string, Stack<Product>>();
            this.storages = new Dictionary<string, Storage>();
        }

        public string AddProduct(string type, double price)
        {
            var product = this.productFactory.CreateProduct(type, price);
            if (!this.products.ContainsKey(type))
            {
                this.products.Add(type, new Stack<Product>());
            }
            this.products[type].Push(product);
            return $"Added {type} to pool";
        }

        public string RegisterStorage(string type, string name)
        {
            Storage storage = this.storageFactory.CreateStorage(type, name);
            this.storages.Add(name, storage);
            return $"Registered {name}";
        }

        public string SelectVehicle(string storageName, int garageSlot)
        {
            Storage storage = this.storages[storageName];
            this.currentVehicle = storage.GetVehicle(garageSlot);
            return $"Selected {this.currentVehicle.GetType().Name}";
        }

        public string LoadVehicle(IEnumerable<string> productNames)
        {
            int productCounter = 0;

            foreach (string productName in productNames)
            {
                if (this.currentVehicle.IsFull)
                {
                    break;
                }
                if (!this.products.ContainsKey(productName)
                    || this.products[productName].Count==0)
                {
                    throw new InvalidOperationException($"{productName} is out of stock");
                }
                var product = this.products[productName].Pop();

                this.currentVehicle.LoadProduct(product);
                productCounter++;
            }
            return $"Loaded {productCounter}/{productNames.Count()} products into {this.currentVehicle.GetType().Name}";

        }

        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            if (!this.storages.ContainsKey(sourceName))
            {
                throw new InvalidOperationException("Invalid source storage!");
            }
            if (!this.storages.ContainsKey(destinationName))
            {
                throw new InvalidOperationException("Invalid destination storage!");
            }
            Storage sourceStorage = this.storages[sourceName];
            Storage destinationStorage = this.storages[destinationName];
            Vehicle vehicle = sourceStorage.GetVehicle(sourceGarageSlot);

            int destinationGarageSlot = sourceStorage.SendVehicleTo(sourceGarageSlot, destinationStorage);

            return $"Sent {vehicle.GetType().GetType().Name} to {destinationName} (slot {destinationGarageSlot})";


        }

        public string UnloadVehicle(string storageName, int garageSlot)
        {
            //TODO - Add functionality
            throw new NotImplementedException();
        }

        public string GetStorageStatus(string storageName)
        {
            throw new NotImplementedException();
        }

        public string GetSummary()
        {
            throw new NotImplementedException();
        }

    }
}
