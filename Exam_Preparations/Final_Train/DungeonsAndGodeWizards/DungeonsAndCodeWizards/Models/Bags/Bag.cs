using DungeonsAndCodeWizards.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonsAndCodeWizards.Models.Bags
{
    public abstract class Bag
    {
        private const int defaultCapacity = 100;
        private int capacity;
        private List<Item> items;

        protected Bag()
        {
            this.Capacity = defaultCapacity;
            this.items = new List<Item>();
        }

        protected Bag(int capacity)
        {
            this.Capacity = capacity;
            this.items = new List<Item>();
        }

        public int Load => this.Items.Sum(x => x.Weight);
        public IReadOnlyCollection<Item> Items => this.items.AsReadOnly();

        public int Capacity
        {
            get { return capacity; }
            private set { capacity = value; }
        }

        //Methods
        public void AddItem(Item item)
        {
            if (item.Weight+this.Load>this.Capacity)
            {
                throw new InvalidOperationException("Bag is full!");
            }
            this.items.Add(item);
        }
        public Item GetItem(string name)
        {
            if (this.items.Count == 0)
            {
                throw new InvalidOperationException("Bag is empty!");
            }
            var temp = this.items.FirstOrDefault(n => n.GetType().Name == name);
            if (temp == null)
            {
                throw new ArgumentException($"No item with name {name} in bag!");
            }
            this.items.Remove(temp);
            return temp;
        }
    }
}
