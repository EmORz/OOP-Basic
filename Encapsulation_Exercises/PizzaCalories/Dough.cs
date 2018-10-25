namespace PizzaCalories
{
    using System;

    public class Dough
    {
        private string flourType;
        private string bakingTech;
        private int weight;
        private const double baseCaloriesPerGram = 2;

        public Dough(string flourType, string bakingTech, int weight)
        {
            this.FlourType = flourType;
            this.BakingTech = bakingTech;
            this.Weight = weight;
        }

        public string FlourType
        {
            get => flourType;
            private set
            {
                bool isValidTech = value.ToLower() != "white" || value.ToLower() != "wholegrain";
                if (isValidTech)
                {
                    ExceptionTech();
                }
                flourType = value;
            }
        }
        public string BakingTech
        {
            get => bakingTech;
            private set
            {
                bool isValidTech = value.ToLower() != "crispy" || value.ToLower() != "chewy" || value.ToLower() != "homemade";
                if (isValidTech)
                {
                    ExceptionTech();
                }
                bakingTech = value;

            }
        }

        private void ExceptionTech()
        {
            Exception ex = new ArgumentException("Invalid type of dough.");
            Console.WriteLine(ex.Message);
            Environment.Exit(0);
        }
        public int Weight
        {
            get => weight;
            private set
            {
                if (value < 1 || value > 200)
                {
                    Exception ex = new ArgumentException("Dough weight should be in the range [1..200].");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                weight = value;
            }
        }
        public double GetCaloriesS { get=> this.GetCalories(); }
        //method
        //GetCalories - 1.
        public double GetCalories()
        {
            var modifier = baseCaloriesPerGram;

            switch (this.FlourType.ToLower())
            {
                case "white":
                    modifier *= 1.5;
                    break;
                //case "wholegrain":
                ////    modifier *= 1.5;
                //    break;
            }
            switch (this.BakingTech)
            {
                case "crispy":
                    modifier *= 0.9;
                    break;
                case "chewy":
                    modifier *= 1.1;
                    break;
                case "homemade":
                    modifier *= 1.0;
                    break;
            }
            return this.Weight * modifier;

        }

    }
}
