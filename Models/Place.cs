using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace TravelApi.Models
{
  public class Place
  {
    [Required]
    public int PlaceId { get; set; }
    [Required]
    public double AverageRating { get; set; }
    [Required]
    public string Landmark { get; set; }
    [Required]
    public string City { get; set; }
    [Required]
    public string Country { get; set; }
    [Required]
    public virtual IEnumerable<Review> Reviews { get; set; }

  }
}