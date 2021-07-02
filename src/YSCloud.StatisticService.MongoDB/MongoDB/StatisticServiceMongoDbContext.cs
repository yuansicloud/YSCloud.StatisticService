using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace YSCloud.StatisticService.MongoDB
{
    [ConnectionStringName(StatisticServiceDbProperties.ConnectionStringName)]
    public class StatisticServiceMongoDbContext : AbpMongoDbContext, IStatisticServiceMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureStatisticService();
        }
    }
}