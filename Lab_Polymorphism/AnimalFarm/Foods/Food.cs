using AnimalFarm.Foods.Contracts;

namespace AnimalFarm.Foods
{
    public abstract class Food : IFoods
    {
        private int quantity;

        protected Food(int quantity)
        {
            this.Quantity = quantity;
        }

        public int Quantity
        {
            //TODO Add validation
            get { return quantity; }
            set { quantity = value; }
        }





    }
}
