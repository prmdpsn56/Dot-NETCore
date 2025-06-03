using Microsoft.AspNetCore.Http.HttpResults;
using RestAPi.Dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGamesEndpoints();


app.Run();
