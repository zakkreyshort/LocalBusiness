using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LocalBusinessApi.Models;

using System.Net;
using System.Net.Http;
// // using System.Web.Http.Filters;

namespace LocalBusinessApi.Controllers
{
  [Route("api/categories/{categoryId}/places/{placeId}/[controller]")]
  [ApiController]
  public class CommentsController : ControllerBase
  {

    private LocalBusinessApiContext _db;

    public CommentsController(LocalBusinessApiContext db)
    {
      _db = db;
    }

    // GET api/Comments
    [HttpGet]
    public ActionResult<IEnumerable<Comment>> Get()
    {
      return _db.Comments.ToList();
    }

    // GET api/Comments/5
    [HttpGet("{id}")]
    public ActionResult<Comment> Get(int id)
    {
      Comment thisComment = _db.Comments.FirstOrDefault(comment => comment.CommentId == id);
      return thisComment;
    }

    // POST api/Comments
    [HttpPost]
    public void Post(int placeId,[FromBody] Comment comment)
    {
        comment.DateCreated = DateTime.Now;
        comment.EditDate = DateTime.Now;
        comment.PlaceId = placeId;
        _db.Comments.Add(comment);
        _db.SaveChanges();
    }

    // PUT api/Comments/5
    [HttpPut("{id}")]
    public void Put(int id, int placeId, [FromBody] Comment comment)
    {
      comment.EditDate = DateTime.Now;
      comment.CommentId = id;
      comment.PlaceId = placeId;
      _db.Entry(comment).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      Comment thisComment = _db.Comments.FirstOrDefault(comment => comment.CommentId == id);
      _db.Comments.Remove(thisComment);
      _db.SaveChanges();
    }
  }
}