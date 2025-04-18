using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using proekt.Models;

namespace proekt.Services
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Request> DRequest { get; set; }
    }
}
