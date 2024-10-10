using Microsoft.EntityFrameworkCore;
using TanakBackend.ApplicationService.Services;
using TanakBackend.Domain.IRepositoryies;
using TanakBackend_InfraStructure.Context;
using TanakBackend_InfraStructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();
#region Register Services
builder.Services.AddScoped<CategoryService, CategoryService>();
#endregion
#region Register Repositories
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
#endregion
#region Register DbContext
builder.Services.AddDbContext<TanakContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("TanakProject"));
});
#endregion
// Configure the HTTP request pipeline.

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
});

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
