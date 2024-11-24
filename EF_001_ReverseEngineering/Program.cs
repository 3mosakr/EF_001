using EF_001_ReverseEngineering.Data;

namespace EF_001_ReverseEngineering
{
    internal class Program
    {
        // Step #1: Package Manager Console (PMC)
        //    Tools -> Nuget Package Manager -> Package Manager Console

        // Step #2: Package Manager Console (PMC) Tool 
        //    Install-Package Microsoft.EntityFrameworkCore.Tools

        // Step #3: Install Nuget Page on Project Microsoft.EntityFrameworkCore.Design
        //    Install-Package Microsoft.EntityFrameworkCore.Design

        // Step #4: Install Provider in the project Microsoft.EntityFrameworkCore.SqlServer

        // Step #5: Run Command (Full)
        //    Scaffold-DbContext '[Connection String]' [Provider]

        // Scaffold-DbContext
        // 'Data Source=.\SQLEXPRESS;Database=TechTalk;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False'
        // Microsoft.EntityFrameWorkCore.SqlServer
        // -context AppDbContext -contextDir Data -outputDir Entity

        public static void Main(string[] args)
        {
            foreach (var item in new AppDbContext().Speakers)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
            Console.ReadKey();
        }
    }
}
