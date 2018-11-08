﻿namespace AnimalFarm.Animals.Contracts
{
    public interface IAnimal
    {
        string Name   { get; }
        double Weight { get; }
        int FoodEaten { get; }
    }
}
