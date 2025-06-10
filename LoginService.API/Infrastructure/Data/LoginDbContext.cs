using Microsoft.EntityFrameworkCore;
using LoginService.API.Domain.Entities;

namespace LoginService.API.Infrastructure.Data

{
    public class LoginDbContext : DbContext
    {
        public LoginDbContext(DbContextOptions<LoginDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
