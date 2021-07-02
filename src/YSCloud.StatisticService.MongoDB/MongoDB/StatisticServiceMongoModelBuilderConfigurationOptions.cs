using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace YSCloud.StatisticService.MongoDB
{
    public class StatisticServiceMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public StatisticServiceMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}