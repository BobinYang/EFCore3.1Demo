using Demo.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Demo.Data
{
    public class ContextDemo : DbContext
    {
        public ContextDemo()
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(ConsolLoggerFactory)
                .EnableSensitiveDataLogging(true)
                .UseSqlServer(@"Data Source=(localdb)\V11.0;Initial Catalog=efcoreDemo;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //为GamePlayer设置联合主键
            modelBuilder.Entity<GamePlayer>().HasKey(x => new { x.PlayerId, x.GameId });
            //指定一对一关系
            modelBuilder.Entity<Resume>()
                .HasOne(x => x.Player)
                .WithOne(x => x.Resume)
                .HasForeignKey<Resume>(x => x.PlayerId);
        }

        public DbSet<League> Leagues { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Resume> Players { get; set; }
        public static readonly ILoggerFactory ConsolLoggerFactory =
            LoggerFactory.Create(builer =>
            {
                builer.AddFilter((category, level) => category == DbLoggerCategory.Database.Command.Name
                && level == LogLevel.Information)
                .AddConsole();
            });
    }
}