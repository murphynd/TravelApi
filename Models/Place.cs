using System;
namespace TravelApi.Models
{
  public class Place
  {
    public int PlaceId { get; set; }
    public string Name { get; set; }

    public string Review { get; set; }
    public DateTime Date { get; set; }

    public int rating { get; set; }
  }
}