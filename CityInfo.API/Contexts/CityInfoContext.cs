using CityInfo.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Contexts
{
    public class CityInfoContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<PointOfInterest> PointsOfInterest { get; set; }

        public CityInfoContext(DbContextOptions<CityInfoContext> options)
                : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                    .HasData(
                    new City()
                    {
                        Id = 1,
                        Name = "Auckland",
                        Description = "The big smoke"
                    },
                    new City()
                    {
                        Id = 2,
                        Name = "Sydney",
                        Description = "The one with the famous Opera House"
                    },
                    new City()
                    {
                        Id = 3,
                        Name = "Paris",
                        Description = "The one with the big metal tower"
                    }
                    );
            modelBuilder.Entity<PointOfInterest>()
                .HasData(
                    new PointOfInterest()
                    {
                        Id = 1,
                        Name = "Skytower",
                        Description = "Big tower in the centre of town that you can have dinner at or jump off.",
                        CityId= 1
                    },
                    new PointOfInterest()
                    {
                        Id = 2,
                        Name = "Mount Eden",
                        Description = "Volcano with awesome views over the whole of Auckland.",
                        CityId = 1
                    },
                    new PointOfInterest()
                    {
                        Id = 3,
                        Name = "Opera House",
                        Description = "Opera House in the shape of a sail.",
                        CityId = 2
                    },
                    new PointOfInterest()
                    {
                        Id = 4,
                        Name = "Darling Harbour",
                        Description = "Great area to stroll around and take in the sights.",
                        CityId = 2
                    },
                    new PointOfInterest()
                    {
                        Id = 5,
                        Name = "Eiffel Tower",
                        Description = "Big tower in the centre of the city.",
                        CityId = 3
                    },
                    new PointOfInterest()
                    {
                        Id = 6,
                        Name = "Louvre",
                        Description = "Fantastic Museum full of art.",
                        CityId = 3
                    }
                    );
                    base.OnModelCreating(modelBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("connectionstring");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
