// using System.Threading.Tasks;

namespace LocalBusinessApi.Models
{
  public interface IUserManagementService
  {
    // Task<bool> IsValidUser(string userName, string password);
    bool IsValidUser(string username, string password);
  }
}