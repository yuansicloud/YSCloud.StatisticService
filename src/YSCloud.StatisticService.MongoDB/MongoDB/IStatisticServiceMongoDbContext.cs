using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace YSCloud.StatisticService.MongoDB
{
    [ConnectionStringName(StatisticServiceDbProperties.ConnectionStringName)]
    public interface IStatisticServiceMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
