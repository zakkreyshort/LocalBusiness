using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace LocalBusinessApi.Models
{
  public class Place
  {
    public int PlaceId { get; set; }
    [Required]
    [StringLength(100)]
    public string Title { get; set; }
    [Required]
    [StringLength(255)]
    public string Body { get; set; }
    public int AuthorId { get; set; }
    public int CategoryId { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime EditDate { get; set; }
    // public int Score { get; set; }
    public string ImageSource { get; set; }

    public Place()
    {
      this.Comments = new HashSet<Comment>();
    }

    public ICollection<Comment> Comments { get; set; }
  }
}