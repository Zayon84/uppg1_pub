using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using uppg1_pub.Server.Data;
using uppg1_pub.Server.Data.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddDbContext<GamesDbContext>(options => options
    .UseNpgsql(builder.Configuration.GetConnectionString("defaultconnectstring"))
    .UseCamelCaseNamingConvention());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
}

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

// games
app.MapGet("games", (GamesDbContext context) =>
{
    return context.GamesTable.ToList();
});

app.MapPost("games", (GamesDbContext context, GamesModel game) =>
{
    context.GamesTable.Add(game);
    context.SaveChanges();
});

// genre
app.MapGet("genre", (GamesDbContext context) =>
{
    return context.GenreTable.ToList();
});

app.MapPost("genre", (GamesDbContext context, GenreModel genre) =>
{
    context.GenreTable.Add(genre);
    context.SaveChanges();
});

// genre
app.MapGet("games/genre/{id:int}", (GamesDbContext context, int id) =>
{
    
    return context.GamesTable.Where(o => o.GenreId == id).ToList();
});

app.Run();
