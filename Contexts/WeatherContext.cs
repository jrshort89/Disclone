using Disclone.Models;
using Microsoft.EntityFrameworkCore;

namespace Disclone.Contexts;

public class WeatherContext : DbContext
{
    public WeatherContext(DbContextOptions<WeatherContext> options)
        : base(options)
    {
        
    }

    public DbSet<WeatherForecast> WeatherForecasts { get; set; }
    public DbSet<Message> Messages { get; set; }
}