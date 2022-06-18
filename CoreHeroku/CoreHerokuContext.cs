using Microsoft.EntityFrameworkCore;

namespace CoreHeroku
{
    public class CoreHerokuContext : DbContext
    {
        public CoreHerokuContext(DbContextOptions<CoreHerokuContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          => optionsBuilder.UseNpgsql("Host=localhost;Database=postgres;Port=5432;Username=postgres;Password=1");


       // public DbSet<CoreHeroku.Model.Persoana> Person { get; set; }
    }
}