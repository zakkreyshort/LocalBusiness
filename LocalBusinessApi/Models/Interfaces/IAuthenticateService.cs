namespace LocalBusinessApi.Models
{

  public interface IAuthenticateService
  {
      bool IsAuthenticated(TokenRequest request, out string token);
  }

}