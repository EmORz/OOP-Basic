using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Trainer> trainers = new List<Trainer>();

            while (input != "Tournament")
            {
                //TrainerName> <PokemonName> <PokemonElement> <PokemonHealth>” 
                string[] tokens = input.Split();
                var trainerName = tokens[0];
                var pokemonName = tokens[1];
                var pokemonElement = (tokens[2]);
                var pokemonHealth = int.Parse(tokens[3]);
                //

                if (!trainers.Any(x => x.name == trainerName))
                {
                    trainers.Add(new Trainer(trainerName));
                }
                var trainer = trainers.First(x => x.name == trainerName);
                trainer.pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
                input = Console.ReadLine();
            }
            input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input.Split();
                var element = tokens[0];

                foreach (Trainer item in trainers)
                {
                    if (item.pokemons.Any(x => x.element == element))
                    {
                        item.badges++;
                    }
                    else
                    {
                        foreach (Pokemon pokemon in item.pokemons)
                        {
                            pokemon.health -= 10;
                        }
                        item.pokemons = item.pokemons.Where(x => x.health > 0).ToList();
                    }
                }
                input = Console.ReadLine();

            }
            foreach (Trainer trainer in trainers.OrderByDescending(x => x.badges))
            {
                Console.WriteLine($"{trainer.name} {trainer.badges} {trainer.pokemons.Count}");
            }
        }
    }
}
