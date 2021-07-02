using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace YSCloud.StatisticService.EntityFrameworkCore
{
    public class StatisticServiceHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<StatisticServiceHttpApiHostMigrationsDbContext>
    {
        public StatisticServiceHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<StatisticServiceHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("StatisticService"));

            return new StatisticServiceHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
