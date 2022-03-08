using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Data
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(new Country()
            {
                Id = 1,
                Name = "Jamaica",
                ShortName = "JM"
            },
            new Country()
            {
                Id = 2,
                Name = "Bahamas",
                ShortName = "BS"
            },
            new Country()
            {
                Id = 3,
                Name = "Cayman Island",
                ShortName = "CI"
            });
            modelBuilder.Entity<Hotel>().HasData(new Hotel()
            {
                Id = 1,
                Name = "Taj Hotel",
                Address="Mumbai",
                CountryId=1,
                Rating=4
            },
            new Hotel()
            {
                Id = 2,
                Name = "Palm Star",
                Address = "Delhi",
                CountryId = 2,
                Rating = 4.5
            },
            new Hotel()
            {
                Id = 3,
                Name = "Marriot",
                Address = "Pune",
                CountryId = 3,
                Rating = 3.5
            });
        }
        DbSet<Country> countries { get; set; }
        DbSet<Hotel> hotels { get; set; }
    }
}
