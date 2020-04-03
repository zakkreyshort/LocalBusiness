using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LocalBusinessApi.Models;
using System.Globalization;
using Microsoft.AspNetCore.Authorization;
namespace LocalBusinessApi.Controllers
{
  // [Authorize]
  [Route("api/[controller]")]
  [ApiController]
  public class CategoriesController : ControllerBase
  {

    private LocalBusinessApiContext _db;

    public CategoriesController(LocalBusinessApiContext db)
    {
      _db = db;
    }

    // GET api/categories
    [HttpGet]
    public ActionResult<IEnumerable<Category>> Get()
    {
      return _db.Categories.ToList();
    }

    // GET api/categories/5
    [HttpGet("{id}")]
    public ActionResult<Category> Get(int id)
    {
      Category thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
      thisCategory.Restaurants = _db.Restaurants.Where(restaurants => restaurants.CategoryId == id).ToList(); //! adding display ability of /restaurants to the details functionality of category
      return thisCategory;
    }

    // POST api/categories
    [HttpPost]
    public void Post([FromBody] Category category)
    {
      _db.Categories.Add(category);
      _db.SaveChanges();
    }

    // PUT api/categories/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Category category)
    {
      category.CategoryId = id;
      _db.Entry(category).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/categories/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      Category thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
      _db.Categories.Remove(thisCategory);
      _db.SaveChanges();
    }
  }
}