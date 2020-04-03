using System.Reflection.PortableExecutable;
using LocalBusinessInterface.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace LocalBusinessInterface.Controllers
{
  public class CommentsController : Controller
  {

    public ActionResult CommentDetails(int categoryId, int placeId, int commentId)
    {
      var thisComment = Comment.GetCommentDetails(categoryId, placeId, commentId);
      return View(thisComment);
    }


    public ActionResult Create(int categoryId, int placeId)
    {
      ViewBag.categoryId = categoryId;
      ViewBag.placeId = placeId;
      return View();
    }
    [HttpPost]
    public ActionResult Create(int categoryId, int placeId, Comment comment)
    {
      Comment.CreateComment(categoryId, placeId, comment);
      return RedirectToAction("Details", "Places", new { categoryId = categoryId, placeId = placeId });
    }
    public ActionResult Edit(int categoryId, int placeId, int commentId)
    {
      ViewBag.CategoryId = categoryId;
      ViewBag.placeId = placeId;
      var thisComment = Comment.GetCommentDetails(categoryId, placeId, commentId);
      return View(thisComment);
    }

    [HttpPost]
    public ActionResult Edit(int categoryId, int placeId, Comment comment)
    {
      Comment.PutComment(categoryId, placeId, comment);
      return RedirectToAction("Details", "Places", new { categoryId = categoryId, placeId = placeId });
    }

    public ActionResult Delete(int categoryId, int placeId, int commentId)
    {
      var thisComment = Comment.GetCommentDetails(categoryId, placeId, commentId);
      return View(thisComment);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int categoryId, int placeId, int commentId)
    {
      Comment.DeleteComment(categoryId, placeId, commentId);
    return RedirectToAction("Details", "Places", new { categoryId = categoryId, placeId = placeId });
    }

  }
}