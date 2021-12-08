using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace FinalProject.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GameDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<GameDbContext>>()))
            {
                if (context.Games.Any())
                {
                    return;
                }

                context.Games.AddRange(
                    new Game
                    {
                        Title = "Saving Private Ryan",
                        Genre = "Action",
                        Price = 9.99M,
                        Rating = "R"
                    },
                    new Game
                    {
                        Title = "Schindler's List",
                        Genre = "Drama",
                        Price = 14.99M,
                        Rating = "R"
                    },
                    new Game
                    {
                        Title = "Apocalypse Now",
                        Genre = "War",
                        Price = 9.99M,
                        Rating = "R"
                    },
                    new Game
                    {
                        Title = "Lawrence Of Arabia ",
                        Genre = "Adventure",
                        Price = 18.54M,
                        Rating = "PG"
                    }


                );
                    context.SaveChanges();
                
            }
        }
    }
}