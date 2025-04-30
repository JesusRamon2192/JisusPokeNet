using PokedexApp.Models;
using PokedexApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<PokemonService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

app.MapGet("/pokemons", (PokemonService service) => 
{
    return Results.Ok(service.GetAllPokemons());
});

app.MapGet("/pokemons/{id}", (int id, PokemonService service) =>
{
    var pokemon = service.GetPokemonById(id);
    return pokemon is null ? Results.NotFound() : Results.Ok(pokemon);
});

app.MapGet("/", () => "¡Bienvenido a la Pokedex API! Usa /pokemons para ver la lista de Pokémon.");

app.MapGet("/force-error", (HttpContext context) =>
{
    throw new Exception("Simulated error for CodeStreamYisusCodex");
});

app.Run();