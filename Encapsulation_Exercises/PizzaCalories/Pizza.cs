namespace PizzaCalories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name,List<Topping> toppings)
        {
            this.Name = name;
            this.Toppings = new List<Topping>();
        }

        public string Name
        {
            get => name;
            private set
            {
                if (value.Length<1||value.Length>15)
                {
                    Exception ex = new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                name = value;
            }
        }
        public Dough Dough
        {
            get => dough;
            set
            {
                dough = value;
            }
        }

        internal List<Topping> Toppings
        {
            get => toppings;
            set
            {
                if (value.Count>10)
                {
                    Exception ex = new ArgumentException("Number of toppings should be in range [0..10].");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                toppings = value;
            }
        }

        //Methods 
        // 1. Calculate all calories
        private double CalculateCalories()
        {
            double doughCalories = this.Dough.GetCalories();
            double toppingCalories = this.Toppings.Sum(c => c.ToppingCalories);
            return doughCalories+toppingCalories;
        }
        //2. Add toppings
        public void AddTopping(Topping topping)
        {
            this.Toppings.Add(topping);
        }
        //3. Count num of toppings
        public int GetNumOfToppings()
        {
            return this.Toppings.Count;
        }
        public override string ToString()
        {
            return $"{this.Name} - {this.CalculateCalories()}";
        }
    }
}
