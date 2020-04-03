
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
  public class PlacesController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult Details(int categoryId, int placeId)
    {
      var thisPlace = Place.GetDetails(categoryId, placeId);
      return View(thisPlace);
    }

    public ActionResult Create(int categoryId)
    {
      ViewBag.categoryId = categoryId;
      return View();
    }

    [HttpPost]
    public ActionResult Create(int categoryId, Place place)
    {
      Place.CreatePlace(categoryId, place);
      return RedirectToAction("Details", "Categories", new { id = categoryId });
    }
    public ActionResult Edit(int categoryId, int placeId)
    {
      ViewBag.CategoryId = categoryId;
      var thisPlace = Place.GetDetails(categoryId, placeId);
      return View(thisPlace);
    }

    [HttpPost]
    public ActionResult Edit(int categoryId, Place place)
    {
      Place.PutPlace(categoryId, place);
      return RedirectToAction("Details", "Categories", new { id = categoryId });
    }

    public ActionResult Delete(int categoryId, int placeId)
    {
      var thisPlace = Place.GetDetails(categoryId, placeId);
      return View(thisPlace);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int categoryId, int placeId)
    {
      Place.DeletePost(categoryId, placeId);
      return RedirectToAction("Details", "Categories", new { id = categoryId });
    }

    [HttpPost]
    public ActionResult UpVote(int categoryId, int placeId, int viewId)
    {
      Post.UpVote(categoryId, placeId);
      if(viewId == 1)
      {
        return RedirectToAction("Details", "Categories", new { id = categoryId });
      }
      else 
      {
        return RedirectToAction("Details", "Posts", new { categoryId = categoryId, placeId = placeId });
      }
    }

    [HttpPost]
    public ActionResult DownVote(int categoryId, int placeId, int viewId)
    {
      Post.DownVote(categoryId, placeId);
      if(viewId == 1)
      {
        return RedirectToAction("Details", "Boards", new { id = categoryId });
      }
      else 
      {
        return RedirectToAction("Details", "Posts", new { categoryId = categoryId, placeId = placeId });
      }
    }
  }
}