using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections;

namespace LocalBusinessInterface.Models
{
  public class Place
  {
    public Place()
    {
      this.Comments = new HashSet<Comment>();
    }
    public int PlaceId { get; set; }
    public int CategoryId { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public int score { get; set; }
    public string ImageSource { get; set; }

    public ICollection<Comment> Comments { get; set; }
    public static List<Place> GetPlaces()
    {
      var apiCallTask = ApiHelper.GetAll("Places");
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Place> placeList = JsonConvert.DeserializeObject<List<Place>>(jsonResponse.ToString());
      return placeList;
    }

    public static Place GetDetails(int categoryId, int PlaceId)
    {
      var apiCallTask = ApiHelper.GetPlaces(categoryId, PlaceId);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Place place = JsonConvert.DeserializeObject<Place>(jsonResponse.ToString());

      return place;
    }
    public static void CreatePlace(int categoryId, Place place)
    {
      string jsonPlace = JsonConvert.SerializeObject(place);
      var apiCallTask = ApiHelper.CreatePlace(categoryId, jsonPlace);
    }

    public static void PutPlace(int categoryId, Place place)
    {
      string jsonPlace = JsonConvert.SerializeObject(place);
      var apiCallTask = ApiHelper.PutPlace(categoryId, place.PlaceId, jsonPlace);
    }

    public static void DeletePlace(int categoryId, int placeId)
    {
      var apiCallTask = ApiHelper.DeletePlace(categoryId, placeId);
    }

    public static void UpVote(int categoryId, int placeId)
    {
      var apiCallTask = ApiHelper.UpVote(categoryId, placeId);
    }
    public static void DownVote(int categoryId, int placeId)
    {
      var apiCallTask = ApiHelper.DownVote(categoryId, placeId);
    }
  }
}