using System;
using System.ComponentModel.DataAnnotations;
namespace TravelApi.Models
{
  public class Place
  {
    [Required]
    public int PlaceId { get; set; }
    [Required]
    public string Landmark { get; set; }
    [Required]
    public string City { get; set; }
    [Required]
    public string Country { get; set; }
    [Required]
    public string Review { get; set; }
    [Required]
    public DateTime Date { get; set; }
    [Required]
    [Range(1, 10, ErrorMessage = "rating must be between 1 and 10.")]
    public int Rating { get; set; }
  }
}