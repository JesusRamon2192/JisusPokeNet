using PokedexApp.Models;

namespace PokedexApp.Services;

public class PokemonService
{
    private readonly List<Pokemon> _pokemons = new()
    {
        new Pokemon { Id = 1, Name = "Pikachu", Type = "Electric", ImageUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/25.png" },
        new Pokemon { Id = 2, Name = "Bulbasaur", Type = "Grass/Poison", ImageUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/1.png" },
        new Pokemon { Id = 3, Name = "Charmander", Type = "Fire", ImageUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/4.png" },
        new Pokemon { Id = 4, Name = "Squirtle", Type = "Water", ImageUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/7.png" }
    };

    public List<Pokemon> GetAllPokemons() => _pokemons;
    
    public Pokemon? GetPokemonById(int id) => _pokemons.FirstOrDefault(p => p.Id == id);
}