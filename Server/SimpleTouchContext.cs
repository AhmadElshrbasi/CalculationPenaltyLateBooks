using Microsoft.EntityFrameworkCore;
using SimpleTouchTask.Shared.Models;

namespace SimpleTouchTask.Server
{
    public class SimpleTouchContext : DbContext
    {   
        public DbSet<LibraryCountry> libraryCountries { get; set; }
        public SimpleTouchContext(DbContextOptions<SimpleTouchContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LibraryCountry>().HasData(
                new LibraryCountry
                {
                    Id = 1,
                    Name = "Egypt",
                    CurrencyKey = "EGP",
                    PenaltyValueOneDay=40
                },
                 new LibraryCountry
                 {
                     Id = 2,
                     Name = "Emirate",
                     CurrencyKey = "AED",
                     PenaltyValueOneDay = 5
                 },
                  new LibraryCountry
                  {
                      Id = 3,
                      Name = "Saudi",
                      CurrencyKey = "SAR",
                      PenaltyValueOneDay = 6
                  }

            );

        }
    }

}
