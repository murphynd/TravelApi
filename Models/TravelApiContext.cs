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
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Place>()
          .HasData(
              new Place { PlaceId = -1, Landmark = "casino", City = "Las Vegas", Country = "USA", Review = "Hot", Date = DateTime.Now, Rating = 7 },
              new Place { PlaceId = -2, Landmark = "Empire State building", City = "NYC", Country = "USA", Review = "Crowded", Date = DateTime.Now, Rating = 10 },
              new Place { PlaceId = -3, Landmark = "skidmore fountian", City = "Portland", Country = "USA", Review = "Bridges", Date = DateTime.Now, Rating = 2 },
              new Place { PlaceId = -4, Landmark = "starbucks", City = "Seattle", Country = "USA", Review = "Hills", Date = DateTime.Now, Rating = 4 },
              new Place { PlaceId = -5, Landmark = "art basil", City = "Miami", Country = "USA", Review = "Beaches", Date = DateTime.Today, Rating = 2 }
          );
      builder.Entity<User>()
      .HasData(
        new User { Id = -1, Username = "NatDawg", Password = "yoyoyo" }
      );
    }
  }
}