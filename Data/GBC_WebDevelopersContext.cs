#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GBC_WebDevelopers.Models;

namespace GBC_WebDevelopers.Data
{
    public class GBC_WebDevelopersContext : DbContext
    {
        public GBC_WebDevelopersContext (DbContextOptions<GBC_WebDevelopersContext> options)
            : base(options)
        {
        }

        public DbSet<GBC_WebDevelopers.Models.Products> Products { get; set; }

        public DbSet<GBC_WebDevelopers.Models.Technicians> Technicians { get; set; }

        public DbSet<GBC_WebDevelopers.Models.Customers> Customers { get; set; }

        public DbSet<GBC_WebDevelopers.Models.Incidents> Incidents { get; set; }
    }
}
