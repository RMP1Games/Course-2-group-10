using Microsoft.EntityFrameworkCore;

    public class TBooks
    {
        public int id { get; set; }
        public string name { get; set; }
        public int yearOfCreate { get; set; }
    }

    public class TAuthors
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
    }

    public class TReaders
    {
        public int id { get; set; }
        public int count { get; set; }
    }


namespace WebApplicationTest.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<TBooks> Books { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<TAuthors> Authors { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<TReaders> Readers { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
