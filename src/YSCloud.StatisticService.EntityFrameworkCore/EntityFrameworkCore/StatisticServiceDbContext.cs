using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace YSCloud.StatisticService.EntityFrameworkCore
{
    [ConnectionStringName(StatisticServiceDbProperties.ConnectionStringName)]
    public class StatisticServiceDbContext : AbpDbContext<StatisticServiceDbContext>, IStatisticServiceDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public StatisticServiceDbContext(DbContextOptions<StatisticServiceDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureStatisticService();
        }
    }
}