namespace LocalBusinessApi.Models
{
  public interface IUserManagementService
  {
    bool IsValidUser(string username, string password);
  }
}