using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entities.Products
{
    public abstract class Product
    {
        private double price;
       

        protected Product(double price, double weight)
        {
            this.Price = price;
            this.Weight = weight;
        }

        public double Weight { get; private set; }

        public double Price
        {
            get { return this.price; }
            private set
            {
                if (value<0)
                {
                    throw new InvalidOperationException("Price cannot be negative!");
                }
                    price = value;
           
            }
        }

    }
}
