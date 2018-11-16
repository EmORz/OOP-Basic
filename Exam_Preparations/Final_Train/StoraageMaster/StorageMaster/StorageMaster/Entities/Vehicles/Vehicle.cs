using StorageMaster.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster.Entities.Vehicles
{
    public abstract class Vehicle
    {
        private int capacity;
        private List<Product> trunk;

        protected Vehicle(int capacity)
        {
            this.capacity = capacity;
            this.trunk = new List<Product>();
        }

        public IReadOnlyCollection<Product> Trunk => this.trunk.AsReadOnly();
        public int Capacity
        {
            get { return capacity; }
            private set { capacity = value; }
        }

        public bool IsFull => this.Trunk.Sum(p => p.Weight) >= this.Capacity;
        public bool IsEmpty => this.Trunk.Count == 0;

        //Methods
        public void LoadProduct(Product product)
        {
            if (this.IsFull)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }
            this.trunk.Add(product);
        }

        public Product Unload()
        {
            if (this.IsEmpty)
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }
            var lastProduct = this.trunk[trunk.Count-1];
            this.trunk.RemoveAt(trunk.Count - 1);
            return lastProduct;
        }
    }
}
