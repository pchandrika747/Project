using Microsoft.EntityFrameworkCore;

namespace Project.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Registration> Registration { get; set; }
        public DbSet<selectflight> selectflight { get; set; }
    }
}
