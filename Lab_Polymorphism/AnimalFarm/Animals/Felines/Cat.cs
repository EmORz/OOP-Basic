using System;
using System.Collections.Generic;
using System.Text;
using AnimalFarm.Foods;

namespace AnimalFarm.Animals.Felines
{
    public class Cat : Felines
    {
        private const double foodIncrease = 0.30;
        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(Food food)
        {
            if (food is Vegetable || food is Meat)
            {
                this.Weight += (foodIncrease*food.Quantity);
                this.FoodEaten += food.Quantity;

            }
            else
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        public override void ProducingSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
