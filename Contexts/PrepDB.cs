using Disclone.Models;
using Microsoft.EntityFrameworkCore;

namespace Disclone.Contexts;

public class PrepDB
{
    public static void PrePopulation(IApplicationBuilder app)
    {
        using (var serviceScope = app.ApplicationServices.CreateScope())
        {
            SeedData(app.ApplicationServices.GetService<MessageContext>());
        }
    }

    public static void SeedData(MessageContext context)
    {
        context.Database.Migrate();

        if (!context.Messages.Any())
        {
            context.Messages.AddRange(
                new Message(){messageText = "a sample"},
                new Message(){messageText = "a sample 2"},
                new Message(){messageText = "a sample 3"}
            );
        }

        context.SaveChanges();
    }
}