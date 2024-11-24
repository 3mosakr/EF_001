using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EF_001_1
{
    public class AppDbContext : DbContext
    {
        public DbSet<Wallet> Wallets { get; set; } = null!;

        public AppDbContext(DbContextOptions options) 
            : base(options) { }


    }
}
