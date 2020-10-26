using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TravelApi.Models;

namespace TravelApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class PlacesController : ControllerBase
  {
    private TravelApiContext _db;
    public PlacesController(TravelApiContext db)
    {
      _db = db;
    }
    // GET api/places
    [HttpGet]
    public ActionResult<IEnumerable<Place>> Get()
    {
      return _db.Places.ToList();
    }

    // POST api/places
    [HttpPost]
    public void Post([FromBody] Place place)
    {
      _db.Places.Add(place);
      _db.SaveChanges();
    }
  }
}