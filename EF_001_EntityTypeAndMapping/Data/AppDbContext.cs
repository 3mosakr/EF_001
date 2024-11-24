

using EF_001_EntityTypeAndMapping.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EF_001_EntityTypeAndMapping.Data
{
    public class AppDbContext : DbContext
    {
        
        
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderWithDetailsView> OrderWithDetails { get; set; }
        //public DbSet<OrderBill> OrderBills { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var configurations = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            var constr = configurations.GetSection("constr").Value;

            optionsBuilder.UseSqlServer(constr);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .ToTable("Products", schema: "Inventory")
                .HasKey(x => x.Id);

            //modelBuilder.HasDefaultSchema("Sales");


            // Exclude Entity
            modelBuilder.Ignore<Snapshot>();

            // Mapping View
            modelBuilder.Entity<OrderWithDetailsView>()
                .ToView("OrderWithDetailsView")
                .HasNoKey();

            // Mapping Table valued function
            modelBuilder.Entity<OrderBill>()
                .HasNoKey()
                .ToFunction("GetOrderBill");


            base.OnModelCreating(modelBuilder);
        }



    }
}
