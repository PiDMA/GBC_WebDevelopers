using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GBC_WebDevelopers.Data;
using System;
using System.Linq;

namespace GBC_WebDevelopers.Models
{
    public class TechniciansData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GBC_WebDevelopersContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GBC_WebDevelopersContext>>()))
            {
                // Look for any Technicianss.
                if (context.Technicians.Any())
                {
                    return;   // DB has been seeded
                }

                context.Technicians.AddRange(
                    new Technicians
                    {
                        Name = "Alison Diaz",
                        Email= "alison@gbcwebdevelopers.com",
                        Phone= "800-555-0443"
                    },

                    new Technicians
                    {
                        Name = "Andrew Wilson",
                        Email = "awilson@gbcwebdevelopers.com",
                        Phone = "800-555-0449"
                    },

                    new Technicians
                    {
                        Name = "Gina Fiori",
                        Email = "gfiori@gbcwebdevelopers.com",
                        Phone = "800-555-0459"
                    },

                    new Technicians
                    {
                        Name = "Gunter Wendt",
                        Email = "gunter@gbcwebdevelopers.com",
                        Phone = "800-555-0400"
                    },
                     new Technicians
                     {
                         Name = "Jason Lee",
                         Email = "jason@gbcwebdevelopers.com",
                         Phone = "800-555-0444"
                     }
                );
                context.SaveChanges();
            }
        }
    }
}
