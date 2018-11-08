using System;
using System.Collections.Generic;
using System.Text;
using AnimalFarm.Animals.Mammal;

namespace AnimalFarm.Animals.Felines
{
    public abstract class Felines : Mammal.Mammal
    {
        private string breed;       

        public Felines(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }
        public override string ToString()
        {
            return base.ToString()+ $"{this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
