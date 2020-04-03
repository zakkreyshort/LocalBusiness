using System.Threading.Tasks;
using System;
using RestSharp;

namespace LocalBusinessInterface.Models
{
  public class ApiHelper
  {
    public static async Task<string> GetAll(string controller)
    {
      RestClient client = new RestClient("http://localhost:5000/api/");
      RestRequest request = new RestRequest($"{controller}", Method.GET);
      var response = await client.ExecuteTaskAsync(request); //calls the api, gets a response with everything
      return response.Content; //gets the json body of the response
    }

    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api/");
      RestRequest request = new RestRequest($"categories/{id}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
    public static async Task<string> GetPlaces(int categoryId, int placeId)
    {
      RestClient client = new RestClient("http://localhost:5000/api/");
      RestRequest request = new RestRequest($"categories/{categoryId}/places/{placeId}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task Post(string newCategory)
    {
      RestClient client = new RestClient("http://localhost:5000/api/");
      RestRequest request = new RestRequest($"categories", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newCategory);
      var response = await client.ExecuteTaskAsync(request);
    }

    public static async Task CreatePlace(int categoryId, string newPlace)
    {
      RestClient client = new RestClient("http://localhost:5000/api/");
      RestRequest request = new RestRequest($"categories/{categoryId}/places", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newPlace);
      var response = await client.ExecuteTaskAsync(request);
    }

    public static async Task Put(int id, string newCategory)
    {
      RestClient client = new RestClient("http://localhost:5000/api/");
      RestRequest request = new RestRequest($"categories/{id}", Method.PUT);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newCategory);
      var response = await client.ExecuteTaskAsync(request);
    }
    public static async Task PutPlace(int categoryId, int placeId, string newPlace)
    {
      RestClient client = new RestClient("http://localhost:5000/api/");
      RestRequest request = new RestRequest($"categories/{categoryId}/places/{placeId}", Method.PUT);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newPlace);
      var response = await client.ExecuteTaskAsync(request);
    }

    public static async Task Delete(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"categories/{id}", Method.DELETE);
      request.AddHeader("Content-Type", "application/json");
      var response = await client.ExecuteTaskAsync(request);
    }
    public static async Task DeletePlace(int categoryId, int placeId)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"categories/{categoryId}/places/{placeId}", Method.DELETE);
      request.AddHeader("Content-Type", "application/json");
      var response = await client.ExecuteTaskAsync(request);
    }

    public static async Task UpVote(int categoryId, int placeId)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"categories/{categoryId}/places/{placeId}/upvote", Method.PATCH);
      request.AddHeader("Content-Type", "application/json");
      var response = await client.ExecuteTaskAsync(request);
    }

    public static async Task DownVote(int categoryId, int placeId)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"categories/{categoryId}/places/{placeId}/downvote", Method.PATCH);
      request.AddHeader("Content-Type", "application/json");
      var response = await client.ExecuteTaskAsync(request);
    }
  }
}