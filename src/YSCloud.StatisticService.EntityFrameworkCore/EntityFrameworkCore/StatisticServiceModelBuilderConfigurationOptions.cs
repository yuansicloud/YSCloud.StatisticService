using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace YSCloud.StatisticService.EntityFrameworkCore
{
    public class StatisticServiceModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public StatisticServiceModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}