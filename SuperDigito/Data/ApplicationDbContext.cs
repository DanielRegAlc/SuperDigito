using Microsoft.EntityFrameworkCore;
using SuperDigito.Models;

namespace SuperDigito.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //Models
        public DbSet<Login> Login { get; set; }
        public DbSet<History> History { get; set; }
    }
}
