using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GBC_WebDevelopers.Data;
using System;
using System.Linq;

namespace GBC_WebDevelopers.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GBC_WebDevelopersContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GBC_WebDevelopersContext>>()))
            {
                // Look for any Productss.
                if (context.Products.Any())
                {
                    return;   // DB has been seeded
                }

                context.Products.AddRange(
                    new Products
                    {
                        Code= "TRNY10",
                        Name = "Tournament Master 1.0" ,
                        Price = 4.99M,
                        ReleaseDate = DateTime.Parse("2015-1-12")
                    },

                    new Products
                    {
                        Code = "LEAG10",
                        Name = "League Scheduler 1.0",
                        Price = 4.99M,
                        ReleaseDate = DateTime.Parse("2016-1-5")
                    },

                    new Products
                    {
                        Code = "LEAGD10",
                        Name = "League Scheduler Delux 1.0",
                        Price = 7.99M,
                        ReleaseDate = DateTime.Parse("2016-1-8")
                    },

                    new Products
                    {
                        Code = "DRAFT10",
                        Name = "Draft Manager 1.0",
                        Price = 4.99M,
                        ReleaseDate = DateTime.Parse("2017-1-2")
                    },
                    new Products
                    {
                        Code = "TEAM10",
                        Name = "Team Manager 1.0",
                        Price = 4.99M,
                        ReleaseDate = DateTime.Parse("2017-1-5")
                    },
                    new Products
                    {
                        Code = "TRNY20",
                        Name = "Tournament Master 2.0",
                        Price = 5.99M,
                        ReleaseDate = DateTime.Parse("2018-2-15")
                    },
                     new Products
                     {
                         Code = "DRAFT20",
                         Name = "Draft Manager 2.0",
                         Price = 5.99M,
                         ReleaseDate = DateTime.Parse("2018-2-15")
                     }
                );
                context.SaveChanges();
            }
        }
    }
}
