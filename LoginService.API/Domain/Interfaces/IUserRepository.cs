using LoginService.API.Domain.Entities;

namespace LoginService.API.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetByUsernameAsync(string username);
    }
}
