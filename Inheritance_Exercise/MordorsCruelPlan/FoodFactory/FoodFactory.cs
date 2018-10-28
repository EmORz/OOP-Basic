using MordorsCruelPlan.Foods;
using MordorCruelPlan.Foods;

namespace MordorsCruelPlan.FoodFactory
{
    public class FoodFactory
    {
        public Food CreateFood(string type)
        {
            type = type.ToLower();

            switch (type)
            {
                case "cram":
                    return new Cram();
                case "apple":
                    return new Apple();
                case "lembas":
                    return new Lembas();
                case "melon":
                    return new Melon();
                case "honeycake":
                    return new HoneyCake();
                case "mushrooms":
                    return new Mushrooms();
                default:
                    return new JunkFoods();
            }

        }
    }
}
