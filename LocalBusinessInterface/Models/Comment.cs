using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections;

namespace LocalBusinessInterface.Models
{
  public class Comment
  {
    public string Body { get; set; }
    public string DateCreated { get; set; }
    public int Score { get; set;  }
    public int PlaceId { get; set; }
    public int CommentId { get; set; }


    public static Comment GetCommentDetails(int categoryId, int placeId, int CommentId)
    {
      var apiCallTask = ApiCommentHelper.GetCommentDetails(categoryId, placeId, CommentId);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Comment comment = JsonConvert.DeserializeObject<Comment>(jsonResponse.ToString());

      return comment;
    }
    public static void CreateComment(int categoryId, int placeId, Comment comment)
    {
      string jsonComment = JsonConvert.SerializeObject(comment);
      var apiCallTask = ApiCommentHelper.CreateComment(categoryId, placeId, jsonComment);
    }

    public static void PutComment(int categoryId, int placeId, Comment comment)
    {
      string jsonComment = JsonConvert.SerializeObject(comment);
      var apiCallTask = ApiCommentHelper.PutComment(categoryId, placeId, comment.CommentId, jsonComment);
    }

    public static void DeleteComment(int categoryId, int placeId, int commentId)
    {
      var apiCallTask = ApiCommentHelper.DeleteComment(categoryId, placeId, commentId);
    }
  }
}