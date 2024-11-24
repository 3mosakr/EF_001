using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace EF_001_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DbContext with Dependancy Injection

            //var configuration = new ConfigurationBuilder()
            //    .AddJsonFile("appsettings.json")
            //    .Build();
            //var constr = configuration.GetSection("constr").Value;

            //var services = new ServiceCollection();
            //services.AddDbContext<AppDbContext>(options => options.UseSqlServer(constr));

            //IServiceProvider serviceProvider = services.BuildServiceProvider();

            //using (var context = serviceProvider.GetService<AppDbContext>())
            //{
            //    foreach (var wallet in context.Wallets)
            //    {
            //        Console.WriteLine(wallet);
            //    }
            //}

            // ---------------------------------- 
            // DbContext with Context Factory

            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            var constr = configuration.GetSection("constr").Value;

            var services = new ServiceCollection();
            services.AddDbContextFactory<AppDbContext>(options => options.UseSqlServer(constr));

            IServiceProvider serviceProvider = services.BuildServiceProvider();

            var contextFactory = serviceProvider.GetService<IDbContextFactory<AppDbContext>>();

            using (var context = contextFactory!.CreateDbContext())
            {
                foreach (var wallet in context.Wallets)
                {
                    Console.WriteLine(wallet);
                }
            }
        }
    }
}
