using StorageMaster.Entities.Products;
using StorageMaster.Entities.Storages;
using StorageMaster.Entities.Vehicles;
using StorageMaster.Factory;
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
        private Dictionary<string, Storage> storages;
        private Vehicle currentVehicle;

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
            
            if (!products.ContainsKey(type))
            {
                this.products.Add(type, new Stack<Product>());
            }
            this.products[type].Push(product);

            return $"Added {type} to pool";

        }

        public string RegisterStorage(string type, string name)
        {
            var storage = this.storageFactory.CreateStorage(type, name);
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
            var productCounter = 0;
            foreach (var productName in productNames)
            {
                if (this.currentVehicle.IsFull)
                {
                    break;
                }
                if (!this.products.ContainsKey(productName)
                    ||this.products[productName].Count == 0)
                {
                    throw new InvalidOperationException($"{productName} is out of stock!");
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

            var destinationGarageSlot = sourceStorage.SendVehicleTo(sourceGarageSlot, destinationStorage);
            return $"Sent {vehicle.GetType().Name} to {destinationName} (slot {destinationGarageSlot})";
        }

        public string UnloadVehicle(string storageName, int garageSlot)
        {
            var storage = this.storages[storageName];
            var productsInVehicle = storage.GetVehicle(garageSlot).Trunk.Count;
            var unloadedProductsCount = storage.UnloadVehicle(garageSlot);
            string result = $"Unloaded {unloadedProductsCount}/{productsInVehicle} products at {storageName}";
            return result;
        }

        public string GetStorageStatus(string storageName)
        {
            Storage storage = this.storages[storageName];
            var countProducts = new Dictionary<string, int>();
            foreach (var product in storage.Products)
            {
                var temp = product.GetType().Name;
                if (!countProducts.ContainsKey(temp))
                {
                    countProducts.Add(temp, 1);
                }
                countProducts[temp]++;
            }

            var sumOfProductsWeight = storage.Products.Sum(p => p.Weight);
            var storageCapacity = storage.Capacity;
            var productAsString = countProducts
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .Select(kvp => $"{kvp.Key} {kvp.Value}")
                .ToArray();

            var stockLine = $"Stock ({sumOfProductsWeight}/{storageCapacity}): [{string.Join(", ", productAsString)}]";

            var storageRepresentationAsStr = storage.Garage.Select(z => z == null ? "empty" : z.GetType().Name).ToArray();

            var garageAsLine = $"Garage: [{string.Join("|", storageRepresentationAsStr)}]";
            return stockLine +
                 Environment.NewLine +
                 storageRepresentationAsStr;
        }

        public string GetSummary()
        {
            var sortedStorages = this.storages
                .Select(x => x.Value)
                .OrderByDescending(x => x.Products.Sum(a => a.Price))
                .ToArray();
            StringBuilder sb = new StringBuilder();

            foreach (var storage in sortedStorages)
            {
                var totalMoney = storage.Products.Sum(x => x.Price);

                sb.AppendLine($"{storage.Name}:");
                sb.AppendLine($"Storage worth: ${totalMoney:F2}");

            }
            return sb.ToString().TrimEnd();
        }

    }
}
