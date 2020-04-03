using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LocalBusinessApi.Models;

using System.Globalization;

namespace LocalBusinessApi.Controllers
{
  [Route("api/categories/{categoryId}/[controller]")]
  [ApiController]
  public class PlacesController : ControllerBase
  {

    private LocalBusinessApiContext _db;

    public PlacesController(LocalBusinessApiContext db)
    {
      _db = db;
    }

    // GET api/Places
    [HttpGet]
    public ActionResult<IEnumerable<Place>> Get(int categoryId)
    {
      List<Place> thesePlaces = _db.Places.Where(place => place.CategoryId == categoryId).ToList();
      return thesePlaces;
    }

    // GET api/Places/5
    [HttpGet("{id}")]
    public ActionResult<Place> Get(int categoryId, int id)
    {
      Place thisPlace = _db.Places.FirstOrDefault(place => place.PlaceId == id);
      thisPlace.Comments = _db.Comments.Where(comments => comments.PlaceId == id).ToList();
      return thisPlace;
    }

    // POST api/Places
    [HttpPost]
    public void Post(int categoryId, [FromBody] Place place)
    {
      place.CategoryId = categoryId;
      place.DateCreated = DateTime.Now;
      place.EditDate = DateTime.Now;
      _db.Places.Add(place);
      _db.SaveChanges();
    }

    // PUT api/Places/5
    [HttpPut("{id}")]
    public void Put( int id, int categoryId, [FromBody] Place place)
    {
      place.EditDate = DateTime.Now;
      place.PlaceId = id; //double checking id of the form body is the correct id
      place.CategoryId = categoryId;
      _db.Entry(place).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      Place thisPlace = _db.Places.FirstOrDefault(place => place.PlaceId == id);
      _db.Places.Remove(thisPlace);
      _db.SaveChanges();
    }
  }
}