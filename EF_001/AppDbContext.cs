using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EF_001
{
    public class AppDbContext : DbContext
    {

        public DbSet<Wallet> Wallets { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var configurations = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            // E:\Dot_Net\CS_projects\EF_001\EF_001\appsettings.json  // Embedded Resource
            var constr = configurations.GetSection("constr").Value;

            optionsBuilder.UseSqlServer(constr);
        }

        
    }
}
