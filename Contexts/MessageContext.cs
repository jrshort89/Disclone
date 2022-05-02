using Disclone.Models;
using Microsoft.EntityFrameworkCore;

namespace Disclone.Contexts;

public class MessageContext : DbContext
{
    public MessageContext(DbContextOptions<MessageContext> options)
        : base(options)
    {
        
    }

    public DbSet<WeatherForecast> WeatherForecasts { get; set; }
    public DbSet<Message> Messages { get; set; }
}