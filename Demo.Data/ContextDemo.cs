using Demo.Domain;
using Microsoft.EntityFrameworkCore;

namespace Demo.Data
{
    public class ContextDemo : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\V11.0;Initial Catalog=efcoreDemo;");
        }

        public DbSet<League> Leagues { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}