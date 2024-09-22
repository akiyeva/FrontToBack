using FrontToBack.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        }
        public DbSet<Student>? Students { get; set; }
        public DbSet<Teacher>? Teachers { get; set; }
    }
}
