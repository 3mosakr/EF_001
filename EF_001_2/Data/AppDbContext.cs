

using EF_001_ConventionsOverConfigrations.Data.Config;
using EF_001_ConventionsOverConfigrations.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EF_001_ConventionsOverConfigrations.Data
{
    public class AppDbContext :DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Tweet> Tweets { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var configurations = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var ConnectionString = configurations.GetSection("constr").Value;

            optionsBuilder.UseSqlServer(ConnectionString);
        }


        // use Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // link entity with table name
            //modelBuilder.Entity<User>().ToTable("tblUsers");
            //modelBuilder.Entity<Tweet>().ToTable("tblTweets");
            //modelBuilder.Entity<Comment>().ToTable("tblComments");

            //modelBuilder.Entity<Comment>().Property(p => p.Id).HasColumnName("CommentId");
            //modelBuilder.Entity<Comment>().Property(p => p.CommentBy).HasColumnName("UserId");

            // link using assembly with group configurations
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserConfiguration).Assembly);
        }
    }
}
