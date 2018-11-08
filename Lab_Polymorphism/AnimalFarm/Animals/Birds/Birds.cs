using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm.Animals.Birds
{
    public abstract class Birds : Animal
    {
        private double wingSize;

        protected Birds(string name, double weight, double wingSize) : base(name, weight)
        {
            this.WingSize = wingSize;
        }

        public double WingSize
        {
            get { return wingSize; }
            set { wingSize = value; }
        }
        public override string ToString()
        {
            return base.ToString()+$"{this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }


    }
}
