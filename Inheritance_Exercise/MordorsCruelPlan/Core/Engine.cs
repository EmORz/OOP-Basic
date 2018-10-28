using MordorCruelPlan.Foods;
using MordorsCruelPlan.FoodFactory;
using MordorsCruelPlan.MoodFactory;
using MordorsCruelPlan.Moods;
using System;

namespace MordorssCruelPlan.Core
{
    public class Engine
    {
        private FoodFactory foodFactory;
        private MoodFactory moodFactory;
        private MoodsS moods;
        public Engine()
        {
            this.foodFactory = new FoodFactory();
            this.moodFactory = new MoodFactory();
            this.moods = new MoodsS();
        }

        public void Run()
        {
            int happinessPoints = 0;

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input.Length; i++)
            {
                string type = input[i];
                Food currentFood = foodFactory.CreateFood(type);
                happinessPoints += currentFood.Happiness;

            }
           
            if (happinessPoints<-5)
            {
                moods = moodFactory.CreateMoods("angry");
            }
            else if (happinessPoints >= -5 && happinessPoints <= 0)
            {
                moods = moodFactory.CreateMoods("sad");
            }
            else if (happinessPoints > 0 && happinessPoints <= 15)
            {
                moods = moodFactory.CreateMoods("happy");
            }
            else
            {
                moods = moodFactory.CreateMoods("javascript");

            }
            Console.WriteLine(happinessPoints);
            Console.WriteLine(moods.Name);
        }
    }
}
