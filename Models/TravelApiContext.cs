using Microsoft.EntityFrameworkCore;
using System;

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
              new Place { PlaceId = -1, Name = "Las Vegas", Review = "Hot", Date = DateTime.Now, Rating = 7 },
              new Place { PlaceId = -2, Name = "NYC", Review = "Crowded", Date = DateTime.Now, Rating = 10 },
              new Place { PlaceId = -3, Name = "Portland", Review = "Bridges", Date = DateTime.Now, Rating = 2 },
              new Place { PlaceId = -4, Name = "Seattle", Review = "Hills", Date = DateTime.Now, Rating = 4 },
              new Place { PlaceId = -5, Name = "Miami", Review = "Beaches", Date = DateTime.Today, Rating = 22 }
          );
    }
  }
}