using LoginService.API.Domain.Entities;
using LoginService.API.Domain.Interfaces;

namespace LoginService.API.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _repo;
        public AuthService(IUserRepository repo) => _repo = repo;

        public async Task<User> ValidateLogin(string username, string password)
        {
            var user = await _repo.GetByUsernameAsync(username);
            if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
                return null;
            return user;
        }
    }
}
