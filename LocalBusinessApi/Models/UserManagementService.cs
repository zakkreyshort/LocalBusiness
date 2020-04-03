using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using LocalBusinessApi.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;


namespace LocalBusinessApi.Models
{
  public class UserManagementService : IUserManagementService
  {

    private LocalBusinessApiContext _db;
    
    public UserManagementService(LocalBusinessApiContext db)
    {
      _db = db;
    }

    public bool IsValidUser(string name, string password)
    {
      User thisUser = _db.Users.FirstOrDefault(user => user.Name == name);
      if(thisUser.Password == password)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}