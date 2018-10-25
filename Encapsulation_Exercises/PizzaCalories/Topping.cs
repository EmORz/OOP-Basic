namespace PizzaCalories
{
    using System;

    public class Topping
    {
        private string typeTopping;
        private int weight;
        private const double baseCaloriesPerGram = 2;

        public Topping(string typeTopping, int weight)
        {
           this.TypeTopping = typeTopping;
           this.Weight = weight;
        }
        public string TypeTopping
        {
            get => typeTopping;
            private set
            {
                bool isValidTopping = value.ToLower() != "meat" || value.ToLower() != "veggies" || value.ToLower() != "cheese"
                    ||value.ToLower() != "sauce";

                if (isValidTopping)
                {
                    Exception ex = new ArgumentException($"Cannot place {value} on top of your pizza");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                typeTopping = value;
            }
        }

        public int Weight
        {
            get => weight;
            private set
            {
                if (value < 1 || value > 50)
                {
                    var firstLetter = Char.ToUpper(this.TypeTopping[0])+ this.TypeTopping.Substring(1);
                    Exception ex = new ArgumentException($"{firstLetter} weight should be in the range [1..50].");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                weight = value;
            }
        }
        public double ToppingCalories { get => this.CaloriesCalculate(); }
        //add Method - 1 .
        public double CaloriesCalculate()
        {
            var modifier = baseCaloriesPerGram;
            switch (this.typeTopping)
            {
                case "meat":
                    modifier *= 1.2;
                    break;
                case "veggies":
                    modifier *= 0.8;
                    break;
                case "cheese":
                    modifier *= 1.1;
                    break;
                case "sauce":
                    modifier *= 0.9;
                    break;
            }
            return modifier * this.Weight;
        }
    }
}
