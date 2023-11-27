class Program
{
    static void Main()
    {
        Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

        while (true)
        {
            string command = Console.ReadLine().Trim();
            if (command == "Tournament")
                break;

            string[] tokens = command.Split();
            string trainerName = tokens[0];
            string pokemonName = tokens[1];
            string pokemonElement = tokens[2];
            int pokemonHealth = int.Parse(tokens[3]);

            if (!trainers.ContainsKey(trainerName))
                trainers[trainerName] = new Trainer(trainerName);

            Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
            trainers[trainerName].AddPokemon(pokemon);
        }

        while (true)
        {
            string command = Console.ReadLine().Trim();
            if (command == "End")
                break;

            foreach (var trainer in trainers.Values)
            {
                bool hasElement = trainer.Pokemon.Any(p => p.Element == command);
                if (hasElement)
                {
                    trainer.Badges++;
                }
                else
                {
                    foreach (var pokemon in trainer.Pokemon.ToList())
                    {
                        pokemon.Health -= 10;
                        if (pokemon.Health <= 0)
                            trainer.Pokemon.Remove(pokemon);
                    }
                }
            }
        }

        var sortedTrainers = trainers.Values.OrderByDescending(t => t.Badges).ThenBy(t => t.Name);

        foreach (var trainer in sortedTrainers)
        {
            Console.WriteLine(trainer);
        }
    }
}