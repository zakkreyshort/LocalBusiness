using System.Threading.Tasks;
using System;
using RestSharp;

namespace LocalBusinessInterface.Models
{
  public class ApiCommentHelper
  {

    public static async Task<string> GetCommentDetails(int categoryId, int placeId, int commentId)
    {
      RestClient client = new RestClient("http://localhost:5000/api/");
      RestRequest request = new RestRequest($"categories/{categoryId}/places/{placeId}/comments", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }


    public static async Task CreateComment(int categoryId, int placeId, string newComment)
    {
      RestClient client = new RestClient("http://localhost:5000/api/");
      RestRequest request = new RestRequest($"categories/{categoryId}/places/{placeId}/comments", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newComment);
      var response = await client.ExecuteTaskAsync(request);
    }


    public static async Task PutComment(int categoryId, int placeId, int commentId, string newComment)
    {
      RestClient client = new RestClient("http://localhost:5000/api/");
      RestRequest request = new RestRequest($"categories/{categoryId}/places/{placeId}/comments/{commentId}", Method.PUT);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newComment);
      var response = await client.ExecuteTaskAsync(request);
    }


    public static async Task DeleteComment(int categoryId, int placeId, int commentId)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"categories/{categoryId}/places/{placeId}/comments/{commentId}", Method.DELETE);
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