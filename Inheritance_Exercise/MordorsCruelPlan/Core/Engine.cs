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
        public Engine()
        {
            this.foodFactory = new FoodFactory();
            this.moodFactory = new MoodFactory();           
        }

        public void Run()
        {
            int happinessPoints = 0;

            string[] input = Console.ReadLine().Split();
            for (int i = 0; i < input.Length; i++)
            {
                string type = input[i];
                Food currentFood = foodFactory.CreateFood(type);
                happinessPoints += currentFood.Happiness;

            }
            MoodsS moods;
            if (happinessPoints < -5)
            {
                moods = moodFactory.CreateMoods("angry");
            }
            else if (happinessPoints >= -5 && happinessPoints <= 0)
            {
                moods = moodFactory.CreateMoods("sad");
            }
            else if (happinessPoints >= 1 && happinessPoints < 15)
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
