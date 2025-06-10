using LoginService.API.Domain.Entities;
using LoginService.API.Domain.Interfaces;
using LoginService.API.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;



namespace LoginService.API.Infrastructure.Repositories
{
    public class SqlUserRepository : IUserRepository
    {
        private readonly LoginDbContext _context;
        public SqlUserRepository(LoginDbContext context) => _context = context;

        public async Task<User?> GetByUsernameAsync(string username)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
        }

    }
}
