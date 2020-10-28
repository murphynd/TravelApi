using Microsoft.EntityFrameworkCore;
using System;

namespace TravelApi.Models
{
  public class TravelApiContext : DbContext
  {
    public TravelApiContext()
    {

    }
    public TravelApiContext(DbContextOptions<TravelApiContext> options)
        : base(options)
    {

    }

    public DbSet<Place> Places { get; set; }
    public DbSet<Review> Reviews { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Place>()
          .HasData(
              new Place { PlaceId = -1, AverageRating = 7, Landmark = "casino", City = "Las Vegas", Country = "USA" },
              new Place { PlaceId = -2, AverageRating = 10, Landmark = "Empire State building", City = "NYC", Country = "USA" },
              new Place { PlaceId = -3, AverageRating = 2, Landmark = "skidmore fountian", City = "Portland", Country = "USA" },
              new Place { PlaceId = -4, AverageRating = 4, Landmark = "starbucks", City = "Seattle", Country = "USA" },
              new Place { PlaceId = -5, AverageRating = 2, Landmark = "art basil", City = "Miami", Country = "USA" }
          );
      builder.Entity<Review>()
          .HasData(
              new Review { ReviewId = -1, PlaceId = -1, TravReview = "Hot", Date = DateTime.Now, Rating = 7 },
              new Review { ReviewId = -6, PlaceId = -1, TravReview = "Hotter", Date = DateTime.Now, Rating = 8 },
              new Review { ReviewId = -2, PlaceId = -2, TravReview = "Crowded", Date = DateTime.Now, Rating = 10 },
              new Review { ReviewId = -3, PlaceId = -3, TravReview = "Bridges", Date = DateTime.Now, Rating = 2 },
              new Review { ReviewId = -4, PlaceId = -4, TravReview = "Hills", Date = DateTime.Now, Rating = 4 },
              new Review { ReviewId = -5, PlaceId = -5, TravReview = "Beaches", Date = DateTime.Today, Rating = 2 }
          );
    }
  }
}