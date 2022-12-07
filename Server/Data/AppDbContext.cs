using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace NJAuto.Server.Data
{
    public class AppDbContext : IdentityDbContext<UserEntity>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Shared.Models.Car>? Car { get; set; }
        public DbSet<Shared.Models.Employee>? employees { get; set; }      
    }
}
