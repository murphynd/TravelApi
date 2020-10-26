using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models
{
  public class TravelApiContext : DbContext
  {
    public TravelApiContext(DbContextOptions<TravelApiContext> options)
        : base(options)
    {
    }

    public DbSet<Place> Places { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Place>()
          .HasData(
              new Place { PlaceId = 1, Name = "Las Vegas", Review = "Hot", Date = "2020-10-26", Rating = 7 },
              new Place { PlaceId = 2, Name = "NYC", Review = "Crowded", Date = "2020-10-26", Rating = 10 },
              new Place { PlaceId = 3, Name = "Portland", Review = "Beer", Date = "2020-10-26", Rating = 2 },
              new Place { PlaceId = 4, Name = "Seattle", Review = "Hills", Date = "2020-10-26", Rating = 4 },
              new Place { PlaceId = 5, Name = "Miami", Review = "Beaches", Date = "2020-10-26", Rating = 22 }
          );
    }
  }
}