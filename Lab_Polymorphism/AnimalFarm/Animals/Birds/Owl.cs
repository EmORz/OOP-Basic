using AnimalFarm.Foods;
using System;

namespace AnimalFarm.Animals.Birds
{
    public class Owl : Birds
    {
        private const double foodIncrease = 0.25;

        public Owl(string name, double weight, double wingSize) :
            base(name, weight, wingSize)
        {
        }

        public override void Eat(Food food)
        {
            if (food is Meat)
            {
                this.Weight += (foodIncrease*food.Quantity);
                this.FoodEaten += food.Quantity;

            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        public override void ProducingSound()
        {
            Console.WriteLine("Hoot Hoot");
        }
    }
}
