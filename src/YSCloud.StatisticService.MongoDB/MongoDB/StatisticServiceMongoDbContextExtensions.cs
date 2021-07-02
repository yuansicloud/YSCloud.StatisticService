using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace YSCloud.StatisticService.MongoDB
{
    public static class StatisticServiceMongoDbContextExtensions
    {
        public static void ConfigureStatisticService(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new StatisticServiceMongoModelBuilderConfigurationOptions(
                StatisticServiceDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}