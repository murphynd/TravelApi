using System;
using System.ComponentModel.DataAnnotations;
namespace TravelApi.Models
{
  public class Review
  {
    public int ReviewId { get; set; }
    [Required]
    public string TravReview { get; set; }
    [Required]
    public DateTime Date { get; set; }
    [Required]
    [Range(1, 10, ErrorMessage = "rating must be between 1 and 10.")]
    public int Rating { get; set; }
    public int PlaceId { get; set; }


  }
}