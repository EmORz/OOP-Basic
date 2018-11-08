using AnimalFarm.Animals;
using AnimalFarm.Animals.Birds.Factory;
using AnimalFarm.Animals.Felines.Factory;
using AnimalFarm.Animals.Mammal.Factory;
using AnimalFarm.Foods.Contracts.Factory;
using System;
using System.Collections.Generic;

namespace AnimalFarm.Core
{

    public class Engine
    {
        private BirdFactory birdFactory;
        private FelineFactory felineFactory;
        private MammalFactory mammalFactory;
        private FoodFactory foodFactory;
        private List<Animal> animals;
        private Animal animal;

        public Engine()
        {
            this.birdFactory = new BirdFactory();
            this.felineFactory = new FelineFactory();
            this.mammalFactory = new MammalFactory();
            this.foodFactory = new FoodFactory();
            this.animals = new List<Animal>();

        }
        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] animalInfo = input.Split();
                string[] foodlInfo = Console.ReadLine().Split();
                string animalType = animalInfo[0];
                string animalName = animalInfo[1];
                double animalWeight = double.Parse(animalInfo[2]);

                if (animalType == "Hen" || animalType == "Owl")
                {
                    double wingSize = double.Parse(animalInfo[3]);
                    animal = this.birdFactory.CreateBirds(animalType, animalName, animalWeight, wingSize);
                }
                else if (animalType == "Mouse" || animalType == "Dog")
                {
                    string livingRegion = (animalInfo[3]);
                    animal = this.mammalFactory.CreateMammal(animalType, animalName, animalWeight, livingRegion);
                }
                else if (animalType == "Cat" || animalType == "Tiger")
                {
                    string livingRegion = (animalInfo[3]);
                    string breed = (animalInfo[4]);
                    animal = this.felineFactory.CreateFelines(animalType, animalName, animalWeight, livingRegion, breed);
                }
                string foodType = foodlInfo[0];
                int quantity = int.Parse(foodlInfo[1]);
                var food = this.foodFactory.CreatFood(foodType, quantity);

                animal.ProducingSound();
                animal.Eat(food);
                animals.Add(animal);

                input = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

        }
    }
}
