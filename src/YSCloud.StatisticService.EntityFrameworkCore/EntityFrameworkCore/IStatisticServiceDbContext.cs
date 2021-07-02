using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace YSCloud.StatisticService.EntityFrameworkCore
{
    [ConnectionStringName(StatisticServiceDbProperties.ConnectionStringName)]
    public interface IStatisticServiceDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}