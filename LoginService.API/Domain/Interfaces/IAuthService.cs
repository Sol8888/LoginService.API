using LoginService.API.Domain.Entities;

namespace LoginService.API.Domain.Interfaces
{
    public interface IAuthService
    {
        Task<User?> ValidateLogin(string username, string password);
    }
}
