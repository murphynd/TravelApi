using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TravelApi.Models;
using TravelApi.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;

namespace TravelApi.Controllers
{
  [Authorize]
  [Route("api/[controller]")]
  [ApiController]
  public class ReviewsController : ControllerBase
  {
    private TravelApiContext _db;
    private readonly IUriService uriService;
    public ReviewsController(TravelApiContext db, IUriService uriService)
    {
      _db = db;
      this.uriService = uriService;
    }
    [HttpGet]
    public IEnumerable<Review> GetAll()
    {

      var query = _db.Reviews;

      return query.ToList();
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
      var review = await _db.Reviews.Where(a => a.ReviewId == id).FirstOrDefaultAsync();
      return Ok(new Response<Review>(review));
    }

    // POST api/reviews
    [HttpPost]
    public void Post([FromBody] Review review)
    {
      _db.Reviews.Add(review);
      Place place = _db.Places.Where(x => x.PlaceId == review.PlaceId).Include(x => x.Reviews).FirstOrDefault(); // 
      if (place.Reviews.Count() != 0)
      {
        double averageRating = place.Reviews.Sum(y => y.Rating);
        averageRating = averageRating / place.Reviews.Count();
        place.AverageRating = averageRating;
      }
      else
      {
        place.AverageRating = 0;
      }
      _db.Entry(place).State = EntityState.Modified;
      _db.SaveChanges();
    }
    // PUT api/reviews/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Review review)
    {
      review.ReviewId = id;
      Place place = _db.Places.Where(x => x.PlaceId == review.PlaceId).Include(x => x.Reviews).FirstOrDefault();
      if (place.Reviews.Count() != 0)
      {
        double averageRating = place.Reviews.Average(y => y.Rating);
        place.AverageRating = averageRating;
      }
      else
      {
        place.AverageRating = 0;
      }
      _db.Entry(place).State = EntityState.Modified;
      _db.Entry(review).State = EntityState.Modified;
      _db.SaveChanges();
    }
    // DELETE api/reviews/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var reviewToDelete = _db.Reviews.FirstOrDefault(entry => entry.ReviewId == id);
      _db.Reviews.Remove(reviewToDelete);
      _db.SaveChanges();
    }


  }
}