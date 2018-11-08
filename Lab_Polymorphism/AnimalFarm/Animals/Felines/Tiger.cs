using AnimalFarm.Foods;
using System;

namespace AnimalFarm.Animals.Felines
{
    public class Tiger : Felines
    {
        private const double foodIncrease = 1.00;
        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
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
                Console.WriteLine($"Tiger does not eat {food.GetType().Name}!");
            }
        }
        public override void ProducingSound()
        {
            Console.WriteLine("ROAR!!!");
        }
    }
}
