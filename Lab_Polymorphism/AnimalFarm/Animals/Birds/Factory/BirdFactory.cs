﻿namespace AnimalFarm.Animals.Birds.Factory
{
    public class BirdFactory
    {
        public Birds CreateBirds(string type, string name, double weight, double wingSize)
        {
            type = type.ToLower();

            switch (type)
            {
                case "owl":
                    return new Owl(name, weight, wingSize);
                case "hen":
                    return new Hen(name, weight, wingSize);
                default:
                    return null;
            }
        }
    }
}
