using EF_001_EntityTypeAndMapping.Data;
using EF_001_EntityTypeAndMapping.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF_001_EntityTypeAndMapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var context = new AppDbContext())
            {
                // basic model
                //foreach (var product in context.Products)
                //{
                //    Console.WriteLine(product.Name);
                //}


                // Exclude Entity
                //foreach (var product in context.Products)
                //{
                //    Console.WriteLine($"{product.Name} \t\n...... loaded at " +
                //        $"{product.Snapshot.LoadedAt.ToString("yyyy-MM-dd hh:mm")}" +
                //        $"\nVersion: {product.Snapshot.Version}");
                //}


                // Mapping View
                //foreach (var item in context.OrderWithDetails)
                //{
                //    Console.WriteLine(item);
                //}




            }
                // mapping Table valued function
            var order1BillDetails = new AppDbContext().Set<OrderBill>()
                .FromSqlInterpolated($"SELECT * FROM GetOrderBill({1})")
                .ToList();
            foreach (var item in order1BillDetails)
            {
                Console.WriteLine(item);
            }
        }
    }
}
