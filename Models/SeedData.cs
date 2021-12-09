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
                    //Mmo Games
                    new Game
                    {
                        Title = "World of Warcraft",
                        Genre = "Mmo",
                        Price = 39.99M,
                        Rating = "8/10"
                    },
                    new Game
                    {
                        Title = "Elder Scrolls Online",
                        Genre = "Mmo",
                        Price = 5.99M,
                        Rating = "7.8"
                    },
                    new Game
                    {
                        Title = "Final Fantasy XIV",
                        Genre = "Mmo",
                        Price = 19.99M,
                        Rating = "8.6/10"
                    },
                    new Game
                    {
                        Title = "Old School Runescape",
                        Genre = "Mmo",
                        Price = 0.00M,
                        Rating = "8/10"
                    },
                    //Fps Games
                    new Game
                    {
                        Title = "Destiny 2",
                        Genre = "Fps",
                        Price = 0.00M,
                        Rating = "8.5/10"
                    },
                    new Game
                    {
                        Title = "Halo Infinite",
                        Genre = "Fps",
                        Price = 59.99M,
                        Rating = "9/10"
                    },
                    new Game
                    {
                        Title = "Call of Duty Vanguard",
                        Genre = "Fps",
                        Price = 59.99M,
                        Rating = "7/10"
                    },
                    new Game
                    {
                        Title = "Battlefield 2042",
                        Genre = "Fps",
                        Price = 59.99M,
                        Rating = "3/10"
                    },
                    //Rpg Games
                    new Game
                    {
                        Title = "Valheim",
                        Genre = "Rpg",
                        Price = 15.99M,
                        Rating = "9/10"
                    },
                    new Game
                    {
                        Title = "Witcher 3",
                        Genre = "Rpg",
                        Price = 7.99M,
                        Rating = "9.3/10"
                    },
                    new Game
                    {
                        Title = "Borderlands 3",
                        Genre = "Rpg",
                        Price = 59.99M,
                        Rating = "9/10"
                    },
                    new Game
                    {
                        Title = "Monster Hunter World",
                        Genre = "Rpg",
                        Price = 19.79M,
                        Rating = "9.5/10"
                    },
                    //Sports Games
                    new Game
                    {
                        Title = "NBA 2K22",
                        Genre = "Sports",
                        Price = 59.99M,
                        Rating = "7/10"
                    },
                    new Game
                    {
                        Title = "Madden 22",
                        Genre = "Sports",
                        Price = 59.99M,
                        Rating = "6/10"
                    },
                    new Game
                    {
                        Title = "FIFA 22",
                        Genre = "Sports",
                        Price = 59.99M,
                        Rating = "7/10"
                    },
                    //Moba Games
                    new Game
                    {
                        Title = "League of Legends",
                        Genre = "Moba",
                        Price = 0.00M,
                        Rating = "9.2/10"
                    },
                    new Game
                    {
                        Title = "Dota 2",
                        Genre = "Moba",
                        Price = 0.00M,
                        Rating = "9.4/10"
                    },
                    new Game
                    {
                        Title = "Smite",
                        Genre = "Moba",
                        Price = 0.00M,
                        Rating = "8.5/10"
                    },
                    //Battle Royal Games
                    new Game
                    {
                        Title = "Fortnite",
                        Genre = "Battle Royal",
                        Price = 0.00M,
                        Rating = "9.6/10"
                    },
                    new Game
                    {
                        Title = "Apex Legends",
                        Genre = "Battle Royal",
                        Price = 0.00M,
                        Rating = "9/10"
                    },
                    new Game
                    {
                        Title = "Call of Duty: Warzone",
                        Genre = "Battle Royal",
                        Price = 0.00M,
                        Rating = "7/10"
                    },
                    new Game
                    {
                        Title = "PUBG",
                        Genre = "Battle Royal",
                        Price = 29.99M,
                        Rating = "9.5/10"
                    },
                    //Racing Games
                    new Game
                    {
                        Title = "Forza Horizon 5",
                        Genre = "Racing",
                        Price = 59.99M,
                        Rating = "10/10"
                    },
                    new Game
                    {
                        Title = "Hot Wheels Unleashed",
                        Genre = "Racing",
                        Price = 34.99M,
                        Rating = "9/10"
                    },
                    new Game
                    {
                        Title = "F1 2021",
                        Genre = "Racing",
                        Price = 29.99M,
                        Rating = "8/10"
                    },
                    //Adventure Games
                    new Game
                    {
                        Title = "Grand Theft Auto V",
                        Genre = "Adventure",
                        Price = 29.99M,
                        Rating = "10/10"
                    },
                    new Game
                    {
                        Title = "Red Dead Redemption 2",
                        Genre = "Adventure",
                        Price = 59.99M,
                        Rating = "10/10"
                    },
                    new Game
                    {
                        Title = "Sea of Thieves",
                        Genre = "Adventure",
                        Price = 39.99M,
                        Rating = "8/10"
                    },
                    new Game
                    {
                        Title = "Star Wars Jedi: Fallen Order",
                        Genre = "Adventure",
                        Price = 14.79M,
                        Rating = "9/10"
                    },
                    new Game
                    {
                        Title = "Super Smash Bros. Ultimate",
                        Genre = "Fighting",
                        Price = 59.99M,
                        Rating = "9.4/10"
                    },
                    new Game
                    {
                        Title = "Dragon Ball FighterZ",
                        Genre = "Fighting",
                        Price = 59.99M,
                        Rating = "8.5/10"
                    },
                    new Game
                    {
                        Title = "Mortal Kombat 11",
                        Genre = "Fighting",
                        Price = 9.99M,
                        Rating = "9/10"
                    }
                    
                    



                );
                    context.SaveChanges();
                
            }
        }
    }
}