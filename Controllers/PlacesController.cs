using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TravelApi.Models;
using Microsoft.EntityFrameworkCore;

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
    public ActionResult<IEnumerable<Place>> Get(string landmark, int rating, string country, string city)
    {
      var query = _db.Places.AsQueryable();
      if (landmark != null)
      {
        query = query.Where(entry => entry.Landmark == landmark); //contains will capture all instances with the name query = query.Where(entry => entry.Name.Contains(name));
      }
      if (rating != 0)
      {
        query = query.Where(entry => entry.Rating == rating);//contains will capture all instances with the name query = query.Where(entry => entry.Name.Contains(name));
      }
      if (country != null)
      {
        query = query.Where(entry => entry.Country == country);//contains will capture all instances with the name query = query.Where(entry => entry.Name.Contains(name));
      }
      if (city != null)
      {
        query = query.Where(entry => entry.City == city);//contains will capture all instances with the name query = query.Where(entry => entry.Name.Contains(name));
      }
      return query.ToList();
    }
    // GET api/places/5
    [HttpGet("{id}")]
    public ActionResult<Place> Get(int id)
    {
      return _db.Places.FirstOrDefault(entry => entry.PlaceId == id);
    }

    // POST api/places
    [HttpPost]
    public void Post([FromBody] Place place)
    {
      _db.Places.Add(place);
      _db.SaveChanges();
    }
    // PUT api/places/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Place place)
    {
      place.PlaceId = id;
      _db.Entry(place).State = EntityState.Modified;
      _db.SaveChanges();
    }
    // DELETE api/places/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var placeToDelete = _db.Places.FirstOrDefault(entry => entry.PlaceId == id);
      _db.Places.Remove(placeToDelete);
      _db.SaveChanges();
    }
  }
}