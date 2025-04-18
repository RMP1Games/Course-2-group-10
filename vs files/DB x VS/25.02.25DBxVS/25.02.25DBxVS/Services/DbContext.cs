using _25._02._25DBxVS.Models;
using Microsoft.EntityFrameworkCore;

namespace _25._02._25DBxVS.Services
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<workers> Dworkers { get; set; }
        public DbSet<consultants> Dconsultants { get; set; }
        public DbSet<managers> Dmanagers { get; set; }
    }
}
