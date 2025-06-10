using LoginService.API.Domain.Entities;
using LoginService.API.Domain.Interfaces;

namespace LoginService.API.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _repo;
        public AuthService(IUserRepository repo)
        {
            _repo = repo;
        }

        public async Task<User?> ValidateLogin(string username, string password)
        {
            Console.WriteLine($"Intentando login para usuario: {username}");

            var user = await _repo.GetByUsernameAsync(username);

            if (user == null)
            {
                Console.WriteLine("Usuario no encontrado.");
                return null;
            }

            if (user.Password != password)
            {
                Console.WriteLine("Contraseña incorrecta.");
                return null;
            }

            Console.WriteLine("Login exitoso.");
            return user;
        }


    }
}
