﻿namespace AnimalFarm.Animals.Felines.Factory
{
    public class FelineFactory
    {
        public Felines CreateFelines (string type, string name, double weight, string livingRegion, string breed)
        {
            type = type.ToLower();
            switch (type)
            {
                case "cat":
                    return new Cat(name, weight, livingRegion, breed);
                case "tiger":
                    return new Tiger(name, weight, livingRegion, breed);
                default:
                    return null;
            }

        }
    }
}
