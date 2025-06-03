using System;
using System.Reflection.Metadata.Ecma335;
using RestAPi.Dtos;

namespace RestAPi.Dtos;

public static class GamesEndPoints
{
private static readonly List<GameDto> games = new List<GameDto>
{
  new GameDto(1, "Game 1", "Description 1", "ImageUrl 1", DateTime.Now, 10.99m, 5),
  new GameDto(2, "Game 2", "Description 2", "ImageUrl 2", DateTime.Now, 20.99m, 4),
    new GameDto(3, "Game 3", "Description 3", "ImageUrl 3", DateTime.Now, 30.99m, 3)
};


public static RouteGroupBuilder MapGamesEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("games").WithParameterValidation();

        group.MapGet("/", () => games);

        group.MapGet("/{id}", (int id) =>
        {
            var result = games.Find(g => g.Id == id);
            return result == null ? Results.NotFound() : Results.Ok(result);
        }
        ).WithName("random");

        group.MapPost("/", (CreateGameDtos creategame) =>
        {
            GameDto newGame = new GameDto(
            games.Count + 1,
            creategame.Name,
            creategame.Description,
            creategame.ImageUrl,
            creategame.ReleaseDate,
            creategame.Price,
            creategame.Rating
        );
            // return Ok{ newGame};
            // games.Add(newGame);
            // return Results.Created($"/games/{newGame.Id}", newGame);
            return Results.CreatedAtRoute("random", new { id = newGame.Id }, newGame);
        });

        group.MapDelete("/{id}", (int id) =>
        {
            games.RemoveAll(g => g.Id == id);
            // return Ok();
            return Results.NoContent();
        });
        
        return group;
    }

}
