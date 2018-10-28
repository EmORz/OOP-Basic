namespace MordorCruelPlan.Foods
{
    public abstract class Food
    {

        protected Food(int happiness)
        {
            this.Happiness = happiness;
        }

        public int Happiness { get;  }

    }
}
