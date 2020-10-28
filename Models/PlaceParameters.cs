using System;
using System.ComponentModel.DataAnnotations;
namespace TravelApi.Models
{
  public class PlaceParameters
  {
    const int maxPageSize = 50;
    public int PageNumber { get; set; } = 1;

    private int _pageSize = 10;
    public int PageSize
    {
      get
      {
        return _pageSize;

      }
      set

      {

        _pageSize = (value > maxPageSize) ? maxPageSize : value;
      }
    }
  }
}