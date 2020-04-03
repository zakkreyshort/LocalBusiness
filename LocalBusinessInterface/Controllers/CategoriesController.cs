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
  public class CategoriesController : Controller
  {
    public IActionResult Index()
    {
      var allCategories = Category.GetCategories();
      return View(allCategories);
    }

    public ActionResult Details(int id)
    {
      var thisCategory = Category.GetDetails(id);
      var placesList = thisCategory.Places.OrderByDescending(place => place.score);
      ViewBag.OrderedPlaces = placesList;
      return View(thisCategory);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Category category)
    {
      Category.Post(category);
      return RedirectToAction("Index");
    }

    public ActionResult Edit(int id)
    {
      var thisCategory = Category.GetDetails(id);
      return View(thisCategory);
    }

    [HttpPost]
    public ActionResult Edit(Category category)
    {
      Category.Put(category);
      return RedirectToAction("Details", new { id = category.CategoryId });
    }

    public ActionResult Delete(int id)
    {
      var thisCategory = Category.GetDetails(id);
      return View(thisCategory);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Category.Delete(id);
      return RedirectToAction("Index");
    }
  }
}