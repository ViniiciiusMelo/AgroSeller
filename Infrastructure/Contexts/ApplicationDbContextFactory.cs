using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Contexts
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                       .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "..", "AgroSeller"))
                       .AddJsonFile("appsettings.json")
                       .Build();

            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            var connectionString = "Host=localhost;Port=5432;Database=desenvolvimento;User Id=admin;Password=admin123;";

            builder.UseNpgsql(connectionString);

            return new ApplicationDbContext(builder.Options);
        }
    }
}
