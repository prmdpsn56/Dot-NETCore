namespace RestAPi.Dtos;

// public record GameDto
// {
//     public int Id { get; init; }
//     public string Name { get; init; } = string.Empty;
//     public string Description { get; init; } = string.Empty;
//     public string ImageUrl { get; init; } = string.Empty;
//     public DateTime ReleaseDate { get; init; }
//     public decimal Price { get; init; }
//     public int Rating { get; init; }
// }


// different syntax for record in new versions of C#

public record GameDto(
    int Id,
    string Name,
    string Description,
    string ImageUrl,
    DateTime ReleaseDate,
    decimal Price,
    decimal Rating
);