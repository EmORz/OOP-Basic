using MordorsCruelPlan.Moods;
using System;

namespace MordorsCruelPlan.MoodFactory
{
    public class MoodFactory
    {
        public MoodsS CreateMoods(string type)
        {
            type = type.ToLower();

            switch (type)
            {
                case "angry":
                    return new Angry();
                case "sad":
                    return new Sad();
                case "happy":
                    return new Happy();
                case "javascript ":
                    return new JavaScript();
                default:
                    throw new Exception("Invalid type!");
            }

        }
    }
}
