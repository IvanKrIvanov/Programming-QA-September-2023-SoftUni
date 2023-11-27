public class Trainer
{
    public string Name { get; set; }
    public int Badges { get; set; }
    public List<Pokemon> Pokemon { get; set; }

    public Trainer(string name)
    {
        Name = name;
        Badges = 0;
        Pokemon = new List<Pokemon>();
    }

    public void AddPokemon(Pokemon pokemon)
    {
        Pokemon.Add(pokemon);
    }

    public override string ToString()
    {
        return $"{Name} {Badges} {Pokemon.Count}";
    }
}