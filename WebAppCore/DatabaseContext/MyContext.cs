using Microsoft.EntityFrameworkCore;
using WebAppCore.Model;

namespace WebAppCore.DatabaseContext
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

        public DbSet<SalesControl> SalesControl { get; set; }
    }
}
