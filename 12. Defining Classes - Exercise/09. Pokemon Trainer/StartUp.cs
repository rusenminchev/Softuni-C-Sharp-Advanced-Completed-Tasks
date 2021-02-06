using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            while (command != "Tournament")
            {
                string[] cmdArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string trainerName = cmdArgs[0];
                string pokemonName = cmdArgs[1];
                string pokemonElement = cmdArgs[2];
                int pokemonHealth = int.Parse(cmdArgs[3]);

                List<Pokemon> listOfPokemon = new List<Pokemon>();
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, new Trainer(trainerName));
                }

                trainers[trainerName].ListOfPokemon.Add(pokemon);

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            Dictionary<string, Trainer> result = new Dictionary<string, Trainer>(trainers);

            while (command != "End")
            {

                foreach ( var (trainerName, trainer) in trainers)
                {

                    if (trainer.ListOfPokemon.Any(x => x.Element == command))
                    {
                        trainer.NumberOfBadges++;
                    }
                    else
                    {
                        for (int i = 0; i < trainer.ListOfPokemon.Count; i++)
                        {
                            trainer.ListOfPokemon[i].Health -= 10;
                            if (trainer.ListOfPokemon[i].Health <= 0)
                            {
                                trainer.ListOfPokemon.Remove(trainer.ListOfPokemon[i]);
                                i--;
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var (trainerNames, trainer) in trainers.OrderByDescending(x => x.Value.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.ListOfPokemon.Count}");
            }
        }
    }
}
