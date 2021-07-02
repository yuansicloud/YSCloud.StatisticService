using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace YSCloud.StatisticService.EntityFrameworkCore
{
    public class StatisticServiceHttpApiHostMigrationsDbContext : AbpDbContext<StatisticServiceHttpApiHostMigrationsDbContext>
    {
        public StatisticServiceHttpApiHostMigrationsDbContext(DbContextOptions<StatisticServiceHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureStatisticService();
        }
    }
}
