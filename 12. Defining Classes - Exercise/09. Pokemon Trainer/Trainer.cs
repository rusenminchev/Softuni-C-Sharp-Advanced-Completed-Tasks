using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {

        public Trainer(string name)
        {
            this.Name = name;
            this.NumberOfBadges = 0;
            this.ListOfPokemon = new List<Pokemon>();

        }
        public string Name { get; set; }

        public int NumberOfBadges { get; set; }
        public List<Pokemon> ListOfPokemon { get; set; }
    }
}
