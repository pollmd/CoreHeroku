using Microsoft.EntityFrameworkCore;

namespace CoreHeroku.Data
{
    public class CoreHerokuContext : DbContext
    {
        public CoreHerokuContext(DbContextOptions<CoreHerokuContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
           => optionsBuilder.UseNpgsql("Host=ec2-176-34-116-203.eu-west-1.compute.amazonaws.com;Port=5432;Database=dec0qf3f5d25p6;Username=vifwksyueayqkr;Password=d1a49cf50b29e95ea7e0918915faecf1aabb78052db69f0e5d380d6ed893c1c5");
        // => optionsBuilder.UseNpgsql("Host=my_host;Database=my_db;Username=my_user;Password=my_pw");
        //  => optionsBuilder.UseNpgsql("Host=localhost;Database=postgres;Port=5432;Username=postgres;Password=1");


        //        Host
        //ec2-34-247-172-149.eu-west-1.compute.amazonaws.com
        //Database
        //d2uank537t415i
        //User
        //vyeqybqgfugiro
        //Port
        //5432
        //Password
        //77715ef26ddf8dcda0fb591cdbac499de8cb9ca7c1ff405654273f40203985e9
        //URI
        //postgres://vyeqybqgfugiro:77715ef26ddf8dcda0fb591cdbac499de8cb9ca7c1ff405654273f40203985e9@ec2-34-247-172-149.eu-west-1.compute.amazonaws.com:5432/d2uank537t415i
        //Heroku CLI
        //heroku pg:psql postgresql-acute-68401 --app milionmd

        public DbSet<CoreHeroku.Model.Persoana> Person { get; set; }
    }
}
