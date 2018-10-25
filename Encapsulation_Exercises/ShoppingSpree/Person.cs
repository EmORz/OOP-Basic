namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> product;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.Product = new List<Product>();
        }

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    Exception ex = new ArgumentException("Name cannot be empty");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                name = value;
            }
        }
        public decimal Money
        {
            get => money;
            set
            {
                if (value < 0)
                {
                    Exception ex = new ArgumentException("Money cannot be negative");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                money = value;
            }
        }
        private List<Product> Product { get => product; set => product = value; }

        public void Add(Product product)
        {
            decimal cost = product.Cost;

            if (cost > this.Money)
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
            else
            {
                this.Product.Add(product);
                this.Money -= cost;
                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
           
        }
        public override string ToString()
        {
            if (this.product.Count ==0)
            {
                return ($"{this.Name} - Nothing bought");
            }
            return $"{this.Name} - {string.Join(", ", product.Select(products => products.ToString()))}";
        }
    }
}
