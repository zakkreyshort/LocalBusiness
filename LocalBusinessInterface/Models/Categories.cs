using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections;


namespace LocalBusinessInterface.Models
{
  public class Category
  {
    public Category()
    {
      this.Places = new HashSet<Place>();
    }
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string BannerImage { get; set; }

    public ICollection<Place> Places { get; set; }
    public static List<Category> GetCategories()
    {
      var apiCallTask = ApiHelper.GetAll("Categories");
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Category> categoryList = JsonConvert.DeserializeObject<List<Category>>(jsonResponse.ToString());
      return categoryList;
    }

    public static Category GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Category category = JsonConvert.DeserializeObject<Category>(jsonResponse.ToString());

      return category;
    }
    public static void Post(Category category)
    {
      string jsonCategory = JsonConvert.SerializeObject(category);
      var apiCallTask = ApiHelper.Post(jsonCategory);
    }

    public static void Put(Category category)
    {
      string jsonCategory = JsonConvert.SerializeObject(category);
      var apiCallTask = ApiHelper.Put(category.CategoryId, jsonCategory);
    }

    public static void Delete(int id)
    {
      var apiCallTask = ApiHelper.Delete(id);
    }
  }
}