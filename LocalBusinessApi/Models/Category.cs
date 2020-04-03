using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace LocalBusinessApi.Models
{
  public class Category
  {
    public int CategoryId { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    [Required]
    [StringLength(255)]
    public string Description { get; set; }
    public Category()
    {
      this.Places = new HashSet<Place>();
    }
    public string BannerImage { get; set; }
  
    public virtual ICollection<Place> Places { get; set; }
  }
    
}