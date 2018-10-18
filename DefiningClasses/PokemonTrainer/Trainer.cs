﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {
        //name, number of badges and a collection of pokemon
        public string name;
        public int badges;
        public List<Pokemon> pokemons;

        public Trainer(string name)
        {
            this.name = name;
            this.badges = 0;
            this.pokemons = new List<Pokemon>();
        }
    }
}
