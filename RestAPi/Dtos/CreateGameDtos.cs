namespace RestAPi.Dtos;

// public record class CreateGameDtos
// {
//     public string Name;
//     public string Description;
//     public string ImageUrl;
//     public DateTime ReleaseDate;
//     public decimal Price;
//     public int Rating;

// }


public record class CreateGameDtos(
    string Name,
    string Description,
    string ImageUrl,
    DateTime ReleaseDate,
    decimal Price,
    decimal Rating
);
