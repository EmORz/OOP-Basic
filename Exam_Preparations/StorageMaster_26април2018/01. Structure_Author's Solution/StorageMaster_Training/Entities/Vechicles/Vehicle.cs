using StorageMaster_Training.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster_Training.Entities.Vechicles
{
    public abstract class Vehicle
    {
        private int capacity;
        private readonly List<Product> trunk;

        protected Vehicle(int capacity)
        {
            this.Capacity = capacity;
            this.trunk = new List<Product>();

        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        public IReadOnlyCollection<Product> Trunk => this.trunk.AsReadOnly();
        public bool IsFool => this.Trunk.Sum(p => p.Weight) >= this.Capacity;
        public bool IsEmpty => !this.Trunk.Any();
        //
        public void LoadProduct(Product product)
        {
            if (this.IsFool)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }
            this.trunk.Add(product);
        }
        public Product Unload()
        {
            if (!this.trunk.Any())
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }
            var products = this.trunk.Last();
            this.trunk.RemoveAt(trunk.Count - 1);
            return products;
        }
    }
}
