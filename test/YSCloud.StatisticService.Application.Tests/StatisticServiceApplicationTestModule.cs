using Volo.Abp.Modularity;

namespace YSCloud.StatisticService
{
    [DependsOn(
        typeof(StatisticServiceApplicationModule),
        typeof(StatisticServiceDomainTestModule)
        )]
    public class StatisticServiceApplicationTestModule : AbpModule
    {

    }
}
