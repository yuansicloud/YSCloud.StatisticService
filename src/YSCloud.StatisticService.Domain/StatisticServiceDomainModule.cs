using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace YSCloud.StatisticService
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(StatisticServiceDomainSharedModule)
    )]
    public class StatisticServiceDomainModule : AbpModule
    {

    }
}
