using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GBC_WebDevelopers.Data;
using System;
using System.Linq;

namespace GBC_WebDevelopers.Models
{
    public static class CustomersData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GBC_WebDevelopersContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GBC_WebDevelopersContext>>()))
            {
                // Look for any Customerss.
                if (context.Customers.Any())
                {
                    return;   // DB has been seeded
                }

                context.Customers.AddRange(
                    new Customers
                    {
                        Firstname = "Kaitlyn",
                        Lastname = "Anthoni",
                        Address = "Queen St",
                        City = "San Francisco",
                        State = "California",
                        PostalCode = "751245",
                        Country = "US",
                        Email = "kanthoni@pge.com",
                        Phone = "647-555-2244"
                    },

                    new Customers
                    {
                        Firstname = "Ania",
                        Lastname = "Irvin",
                        Address = "George St",
                        City = "Washington",
                        State = "Washington",
                        PostalCode = "254786",
                        Country = "US",
                        Email = "ania@mma.nidc.com",
                        Phone = "647-555-2233"
                    },

                    new Customers
                    {
                        Firstname = "Gonzalo",
                        Lastname = "Keeton",
                        Address = "Palm St",
                        City = "Mission Viejo",
                        State = "California",
                        PostalCode = "21465",
                        Country = "US",
                        Email = "",
                        Phone = "647-555-2277"
                    },

                    new Customers
                    {
                        Firstname = "Anton",
                        Lastname = "Mauro",
                        Address = "King St",
                        City = "Sacramento",
                        State = "California",
                        PostalCode = "78945",
                        Country = "US",
                        Email = "amauro@yahoo.org",
                        Phone = "647-555-2211"
                    },

                    new Customers
                    {
                        Firstname = "Kendall",
                        Lastname = "Mayte",
                        Address = "Yonge St",
                        City = "Fresno",
                        State = "California",
                        PostalCode = "124896",
                        Country = "US",
                        Email = "kmayte@fresno.ca.gov",
                        Phone = "647-555-2200"
                    },
                    new Customers
                    {
                        Firstname = "Kenzie",
                        Lastname = "Quinn",
                        Address = "Hollywood St",
                        City = "Los Angeles",
                        State = "California",
                        PostalCode = "546871",
                        Country = "US",
                        Email = "kenzie@mma.jobtrak.com",
                        Phone = "647-555-2233"
                    },
                    new Customers
                    {
                        Firstname = "Marvin",
                        Lastname = "Quinn",
                        Address = "Hall of fame St",
                        City = "Fesno",
                        State = "California",
                        PostalCode = "65248",
                        Country = "US",
                        Email = "marvin@expedeta.com",
                        Phone = "647-555-2269"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
