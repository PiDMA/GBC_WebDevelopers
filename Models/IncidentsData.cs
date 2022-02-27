using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GBC_WebDevelopers.Data;
using System;
using System.Linq;


namespace GBC_WebDevelopers.Models
{
    public static class IncidentsData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GBC_WebDevelopersContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GBC_WebDevelopersContext>>()))
            {
                // Look for any Incidentss.
                if (context.Incidents.Any())
                {
                    return;   // DB has been seeded
                }

                context.Incidents.AddRange(
                    new Incidents
                    {
                        Customer = "Kendall Mayte",
                        Product = "League Scheduler 1.0",
                        Title = "Error launching program",
                        Description = "Program fails with error code 510, unable to open data base.",
                        Technician = "Andrew Wilson",
                        DateOpened = DateTime.Now,
                        DateClosed = DateTime.Now
                    },

                    new Incidents
                    {
                        Customer = "Gonzalo Keeton",
                        Product = "Tournament Master 1.0",
                        Title = "Could not install",
                        Description = "Program fails with error code 510, unable to open data base.",
                        Technician = "Gina Fiori",
                        DateOpened = DateTime.Parse("2020-1-8")
                    },

                    new Incidents
                    {
                        Customer = "Ania Irvin",
                        Product = "League Scheduler Deluxe 1.0",
                        Title = "Error importing data",
                        Description = "Program fails, unable to import data.",
                        Technician = "Jason Lee",
                        DateOpened = DateTime.Parse("2020-1-10"),
                        DateClosed = DateTime.Now
                    },

                    new Incidents
                    {
                        Customer = "Kendall Mayte",
                        Product = "League Scheduler 1.0",
                        Title = "Error launching program",
                        Description = "Program fails with error code 510, unable to open data base.",
                        Technician = "Andrew Wilson",
                        DateOpened = DateTime.Parse("2020-1-10"),
                        DateClosed = DateTime.Now
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
